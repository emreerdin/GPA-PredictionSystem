from sklearn.preprocessing import StandardScaler
import UnityEngine as ue
# Import necessary libraries
import pandas as pd
from sklearn.model_selection import train_test_split
from sklearn.linear_model import LinearRegression
from sklearn.metrics import mean_squared_error

uiObject = ue.GameObject.FindWithTag("Results")
answers = uiObject.GetComponent("Answer")
# Load dataset
df = pd.read_csv('Assets/ProjectFolder/gpaPred.csv')
df = df.dropna()

# Split the data into training and testing sets
X = df.iloc[:, :9]  # input features (first 9 columns)
y = df.iloc[:, 9]  # target variable (10th column)
X_train, X_test, y_train, y_test = train_test_split(
    X, y, test_size=0.2, random_state=42)

# Scale the data
# You can choose to scale the data using StandardScaler or MinMaxScaler
# Here's an example using StandardScaler:
scaler = StandardScaler()
X_train = scaler.fit_transform(X_train)
X_test = scaler.transform(X_test)

# Train the model
model = LinearRegression()
model.fit(X_train, y_train)

# Evaluate the model
y_pred = model.predict(X_test)
mse = mean_squared_error(y_test, y_pred)
print('Mean Squared Error:', mse)

# Make predictions
# Here's an example using a single record from the dataset
record = [[answers.answer1, answers.answer2, answers.answer3, answers.answer4,
           answers.answer5, answers.answer6, answers.answer7, answers.answer8, answers.answer9]]
record_scaled = scaler.transform(record)
prediction = model.predict(record_scaled)

predictionUnityText = ue.GameObject.FindWithTag(
    "Prediction")
pred_str = str(prediction).replace('[', '').replace(']', '')
predictionUnityText.GetComponent("Text").text = pred_str
mseUnityText = ue.GameObject.FindWithTag(
    "MSE")
mse_str = str(mse).replace('[', '').replace(']', '')
mseUnityText.GetComponent("Text").text = mse_str
