#include <ESP8266WiFi.h>
#include "Adafruit_MQTT.h"
#include "Adafruit_MQTT_Client.h"
#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <Adafruit_Sensor.h>

#define ANALOG_INPUT A0   // Analog input from MQ135
#define n 50  
int p = 0;   // Set the CO2 level as 0

WiFiServer server(80);

#define SSID "......"
#define PASS "......"

#define AIO_SERVER "io.adafruit.com"
#define AIO_SERVERPORT 1883 // Use 8883 for SSL

#define AIO_USERNAME  "......"
#define AIO_KEY       "......"

WiFiClient client;

Adafruit_MQTT_Client mqtt(&client, AIO_SERVER, AIO_SERVERPORT, AIO_USERNAME, AIO_KEY);

// Used to publish to MQTT protocol means write operation
Adafruit_MQTT_Publish counter = Adafruit_MQTT_Publish(&mqtt, AIO_USERNAME "/feeds/counter-high");

void MQTT_connection();

void setup(){
	
	Serial.begin(9600);
	delay(10);
	
	Serial.println("Adafruit MQTT");
	WiFi.begin(SSID, PASS);
	while(WiFi.status() != WL_CONNECTED){
		delay(600);
		Serial.print(".");
	}
	Serial.println("Wi-Fi is connected.");
	Serial.println();
	
}

void loop(){
	MQTT_connection();

  int c = analogRead(0);
  p = c - n;   // Formula for caculating PPM
	

	// Write to Adafruit MQTT server
	Serial.print("\nSend PPM value: ");
	Serial.print(p);
	Serial.print("...");
	delay(500);
	if(!counter.publish(p)){
		Serial.println("Failed to send.");
	}
	else{
		Serial.println("Completed!");
	}
	
	if(!mqtt.ping()) mqtt.disconnect();
}

// Functions for connect and reconnect to the MQTT server.
// The function will be loop and take care of it if currently is connecting.
void MQTT_connection(){
	int8_t ret;

	// Stop if MQTT is already connected.
	if(mqtt.connected())
		return;

	Serial.print("MQTT connection (Connecting...)");

	uint8_t retries = 3;
	while((ret = mqtt.connect()) != 0){ // connect will return value 0 for connected
		Serial.println(mqtt.connectErrorString(ret));
		Serial.println("MQTT connection (Retrying in 5 seconds...)");
		mqtt.disconnect();
		delay(12000);  // wait for 12 seconds
		retries--;
		if(retries == 0)
			while (1); // wait for WDT to reset it
	}
	Serial.println("MQTT is Connected!");
}
