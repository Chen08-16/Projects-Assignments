import numpy as np
import skfuzzy as fuzz
import json
import urllib.request
from skfuzzy import control as ctrl

def getResponse(url):
    operUrl = urllib.request.urlopen(url)
    if(operUrl.getcode()==200):
        data = operUrl.read()
        jsonData = json.loads(data)
    else:
        print("Error receiving data", operUrl.getcode())
    return jsonData

urlData = "https://sunflower-tree-system-default-rtdb.firebaseio.com/.json"
jsonData = getResponse(urlData)

TEMPC = jsonData["Sensor"]["Temperature (°C)"]
HUMIDITY = jsonData["Sensor"]["Humidity (%)"]
MOISTURE = jsonData["Sensor"]["Soil Moisture (%)"]
PHOTO = jsonData["Sensor"]["Photo"]
LIGHT = jsonData["Sensor"]["Light Intensity (%)"]

def getCondition():
    soilMoisture = ctrl.Antecedent(np.arange(0, 101, 1), 'soilMoisture')
    temperature = ctrl.Antecedent(np.arange(0, 51, 1), 'temperature')
    humidity = ctrl.Antecedent(np.arange(0, 21, 1), 'humidity')
    plantCondition = ctrl.Consequent(np.arange(0, 101, 1), 'plantCondition')

    soilMoisture.automf(3)

    temperature['low'] = fuzz.trimf(temperature.universe, [0, 0, 25])
    temperature['normal'] = fuzz.trimf(temperature.universe, [0, 25, 50])
    temperature['high'] = fuzz.trimf(temperature.universe, [25, 50, 50])

    humidity['low'] = fuzz.trimf(humidity.universe, [0, 0, 10])
    humidity['normal'] = fuzz.trimf(humidity.universe, [0, 10, 20])
    humidity['high'] = fuzz.trimf(humidity.universe, [10, 20, 20])


    plantCondition['unhealthy'] = fuzz.trimf(plantCondition.universe, [0, 0, 50])
    plantCondition['healthy'] = fuzz.trimf(plantCondition.universe, [50, 100, 100])

    rule1 = ctrl.Rule(soilMoisture['average'] & temperature['normal'] & humidity['normal'] , plantCondition['healthy'])
    rule2 = ctrl.Rule(soilMoisture['good'] | soilMoisture['poor'] | temperature['high'] | temperature['low'] | humidity['high'] | humidity['low'] , plantCondition['unhealthy'])

    plantConditioning_ctrl = ctrl.ControlSystem([rule1, rule2])

    plantConditioning = ctrl.ControlSystemSimulation(plantConditioning_ctrl)

    plantConditioning.input['soilMoisture'] = float(MOISTURE)
    plantConditioning.input['temperature'] = float(TEMPC)
    plantConditioning.input['humidity'] = float(HUMIDITY)

    plantConditioning.compute()

    return plantConditioning.output['plantCondition']