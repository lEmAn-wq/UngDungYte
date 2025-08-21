import joblib
import sys
import os
import pandas as pd

sys.stdout.reconfigure(encoding='utf-8')
sys.stderr.reconfigure(encoding='utf-8')

try:
    base_path = os.path.dirname(os.path.abspath(__file__))
    model_path = os.path.join(base_path, "diabetes_logistic_model.pkl")
    scaler_path = os.path.join(base_path, "scaler.pkl")
    # result_path = os.path.join(base_path, "result.txt")

    model = joblib.load(model_path)
    scaler = joblib.load(scaler_path)

    input_data = list(map(float, sys.argv[1].split(',')))
    columns = ['Pregnancies', 'Glucose', 'BloodPressure', 'SkinThickness',
               'Insulin', 'BMI', 'DiabetesPedigreeFunction', 'Age']
    df = pd.DataFrame([input_data], columns=columns)
    prob = model.predict_proba(scaler.transform(df))[0][1] * 100
    # label = "Có nguy cơ" if prob >= 50 else "Không có nguy cơ"

    # with open(result_path, 'w', encoding='utf-8') as f:
    #     f.write(f"Xác suất mắc bệnh tiểu đường của bạn là: {prob:.2f}%")

    print(f"Xác suất mắc bệnh tiểu đường của bạn là: {prob:.2f}%")

    # print(f"Đã ghi: {prob:.2f}%, {label}")
except Exception as e:
    print(f"Lỗi: {e}", file=sys.stderr)
    sys.exit(1)
