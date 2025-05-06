import io
import discord
import urllib.request
import json
import aiohttp
import random
import webscraping
import fuzzy_logic

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
TEMPF = jsonData["Sensor"]["Temperature (°F)"]
HUMIDITY = jsonData["Sensor"]["Humidity (%)"]
MOISTURE = jsonData["Sensor"]["Soil Moisture (%)"]
PHOTO = jsonData["Sensor"]["Photo"]
LIGHT = jsonData["Sensor"]["Light Intensity (%)"]

WEATHER = webscraping.getWeather()
CONDITION = fuzzy_logic.getCondition()

MTEMP = webscraping.getMTemp()
MLIGHT = webscraping.getMLight()
MWATER = webscraping.getMWater()
MTIPS = webscraping.getMTips()

RTEMP = webscraping.getRTemp()
RLIGHT = webscraping.getRLight()
RWATER = webscraping.getRWater()
RTIPS = webscraping.getRTips()

CTEMP = webscraping.getCTemp()
CLIGHT = webscraping.getCLight()
CWATER = webscraping.getCWater()
CTIPS = webscraping.getCTips()

PTEMP = webscraping.getPTemp()
PLIGHT = webscraping.getPLight()
PWATER = webscraping.getPWater()
PTIPS = webscraping.getPTips()

intents = discord.Intents.all()
client = discord.Client(intents=intents)

@client.event
async def on_ready():
    print(f'{client.user} is online...')

@client.event
async def on_message(message):
    greetings = ['hello', 'hi', 'hey', 'yo']
    greet_responses = ['Hello', 'Hi', 'Hey there', 'May I help you?', 'I am here']

    services = ["what can you do", "what are your skill", "what information that you can tell us"]
    services_responses = "I am here to provide advices that relevant to the plants."

    status = ["how are you", "how do you feel", "are you ok"]
    status_responses = ["I am fine.", "Everything seems good here.", "I feel great!"]

    name = ["who are you", "what is your name", "do you have a name", "what should I call you"]
    name_responses = ["I am Lucy.", "As you can see, my name is Lucy.", "My name is Lucy."]

    thanks = ["thanks", "thank you", "that are helpful", "thx", "thank"]
    thank_responses = ["Happy to help!", "My pleasure", "You are welcome."]

    bye = ["bye", "bye bye", "byebye", "goodbye", "see you", "stop"]
    bye_responses = ["Bye...", "Goodbye!", "See you next time.", "See you..."]

    temperature = ["temperature", "how is the temperature", "temperature of sunflower" "sunflower temperature", "temperature of plant", "plant temperature"]
    soill_moisture = ["soil moisture", "soil", "moisture", "how is the soil moisture", "how is the moisture", "how is the soil", "sunflower soil moisture", "soil moisture of sunflower", "soil moisture of plant", "plant soil moisture"]
    light_intensity = ["light", "light intensity", "how is the light intensity", "how is the light", "sunflower light intensity", "light intensity of sunflower", "light intensity of plant", "plant light intensity"]
    humidity = ["humidity", "how is the humidity", "sunflower humidity", "humidity of sunflower", "humidity of plant", "plant humidity"]
    photo = ["photo", "sunflower photo", "photo of sunflower", "plant photo", "photo of plant", "how is the sunflower looks like"]
    weather = ["weather", "how is the weather", "how is weather", "what is weather", "what is the weather", "current weather", "what is current weather", "how is current weather", "what is the current weather", "how is the current weather"]
    sunflower_status = ["status", "status of sunflower", "status of plant", "how is the plant", "how is the sunflower"]
    other = ["other", "suitable plants for greenhouse in malaysia low land", "malaysia low land plant", "suitable plant in malaysia low land", "suitable plant for greenhouse in malaysia", "plant that suitable grow in malaysia low land", "plant that suitable grow in greenhouse in malaysia"]

    if message.author == client.user:
        return

    if any(message.content.lower().strip() == word for word in greetings):
        await message.channel.send((f"{random.choice(greet_responses)}"))
    
    elif any(message.content.lower().strip() == word for word in services):
        await message.channel.send((f"{(services_responses)}"))

    elif any(message.content.lower().strip() == word for word in name):
        await message.channel.send((f"{random.choice(name_responses)}"))

    elif any(message.content.lower().strip() == word for word in thanks):
        await message.channel.send((f"{random.choice(thank_responses)}"))
    
    elif any(message.content.lower().strip() == word for word in bye):
        await message.channel.send((f"{random.choice(bye_responses)}"))
        await client.close()

    elif any(message.content.lower().strip() == word for word in status):
        await message.channel.send((f"{random.choice(status_responses)}"))

    elif any(message.content.lower().strip() == word for word in sunflower_status):
        await message.channel.send('===================================' + '\nSunflower Status:' + '\nTemperature(°C): ' + TEMPC + '°C' + '\nTemperature(°F): ' + TEMPF + '°F' + '\nHumidity: ' + HUMIDITY + '%' + '\nSoil Moisture: ' + MOISTURE + '%' + '\nLight Intensity: ' + LIGHT + '%' + '\n===================================')
        if CONDITION > 70 or CONDITION < 30:
            await message.channel.send('The sunflower is growing in an unhealth enviroment')
        else:
            await message.channel.send('The sunflower is growing in a health enviroment')

    elif any(message.content.lower().strip() == word for word in photo):
        async with aiohttp.ClientSession() as session:
            async with session.get(PHOTO) as resp:
                data = io.BytesIO(await resp.read())
                await message.channel.send("Photo of sunflower:")
                await message.channel.send(file=discord.File(data, 'sunflower.png'))

    elif any(message.content.lower().strip() == word for word in temperature):
        await message.channel.send('Temperature(°C): ' + TEMPC + '°C' + '\nTemperature(°F): ' + TEMPF + '°F')

        if float(TEMPC) > 35:
            await message.channel.send('The temperature is too high!!!' + '\nNeed to move the sunflower to place where temperature is lower.')
        elif float(TEMPC) < 20:
            await message.channel.send('The temperature is too low!!!' + '\nNeed to move the sunflower to place where temperature is higher.')
        else:
            await message.channel.send('The temperature is suitable for the sunflower.')

    elif any(message.content.lower().strip() == word for word in soill_moisture):
        await message.channel.send('Soil Moisture: ' + MOISTURE + '%')

        if float(MOISTURE) > 40:
            await message.channel.send('The soil is too moist!' + '\nPlease don\'t overwater the sunflower and it might \"drown\" due to having too much water.')
        elif float(MOISTURE) < 20:
            await message.channel.send('The soil is too dry!' + '\nPlease water the sunflower regularly and the sunflower will wilt soon due to lack of water.')
        else:
            await message.channel.send('The soil moisture is suitable for the sunflower.')

    elif any(message.content.lower().strip() == word for word in humidity):
        await message.channel.send('Humidity: ' + HUMIDITY + '%')

        if float(HUMIDITY) > 70:
            await message.channel.send('The humidity is too high!' + '\nYou can move the sunflower to a warmer place to reduce humidity level.' + "\nA place with moving air also can help to reduce the humidity level.")
        elif float(HUMIDITY) < 30 :
            await message.channel.send('The humidity is too low!' + '\nI recommend to spray some water mist on the leaf of the sunflower and put a container filled with water near the sunflower.')
        else:
            await message.channel.send('The humidity is suitable for the sunflower.')

    elif any(message.content.lower().strip() == word for word in light_intensity):
        await message.channel.send('Light intensity: ' + LIGHT + '%')

        if float(LIGHT) > 70:
            await message.channel.send('The light intensity is high! Currently probably is in the daytime.')
            await message.channel.send('If not in daytime, I suggest you to move the sunflower to a place with lower light intensity.')
        elif float(LIGHT) < 40:
            await message.channel.send('The light intensity is low! Currently probably is in the nighttime.')
            await message.channel.send('If not in nighttime, I suggest you to move the sunflower to a place with higher light intensity.')
        else:
            await message.channel.send('The light intensity is suitable for the sunflower.')

    elif any(message.content.lower().strip() == word for word in weather):
        await message.channel.send('Current Weather: ' + WEATHER)

    elif any(message.content.lower().strip() == word for word in other):
        await message.channel.send("Some suitable plants for greenhouse in Malaysia low land:" + "\nMandevilla:" + "\nTemperature Requirement: " + MTEMP + "\nLight Requirement: " + MLIGHT + "\nWater Requirement: " + MWATER + "\n\nCaring Tips:" + "\n" + MTIPS + "\n-------------------------------------------------------------------------------------------------------------------------------------------------" 
                                    + "\nRose:" + "\nTemperature Requirement: " + RTEMP + "\nLight Requirement: " + RLIGHT + "\nWater Requirement: " + RWATER + "\n\nCaring Tips:" + "\n" + RTIPS + "\n-------------------------------------------------------------------------------------------------------------------------------------------------")
        await message.channel.send("\nCauliflower:" + "\nTemperature Requirement: " + CTEMP + "\nLight Requirement: " + CLIGHT + "\nWater Requirement: " + CWATER + "\n\nCaring Tips:" + "\n" + CTIPS + "\n-------------------------------------------------------------------------------------------------------------------------------------------------"
                                    + "\nPitcher Plant:" + "\nTemperature Requirement: " + PTEMP + "\nLight Requirement: " + PLIGHT + "\nWater Requirement: " + PWATER + "\n\nCaring Tips:" + "\n" + PTIPS + "\n-------------------------------------------------------------------------------------------------------------------------------------------------")
    
    else:
        await message.channel.send("I didnt understand it, please type again.")

client.run("......")