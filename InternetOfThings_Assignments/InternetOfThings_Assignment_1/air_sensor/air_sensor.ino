#include <Wire.h>
#include <Adafruit_GFX.h>
#include <Adafruit_SSD1306.h>
#include <Adafruit_Sensor.h>
#include <ESP8266WiFi.h>

// OLED declaration and setup
#define SCREEN_WIDTH 128
#define SCREEN_HEIGHT 32
#define OLED_RESET -1   // Share reset pin with MCU.
Adafruit_SSD1306 display(SCREEN_WIDTH, SCREEN_HEIGHT, &Wire, OLED_RESET);
#define ANALOG_INPUT A0   // Analog input from MQ135
#define n 50  
int p = 0;   // Set the CO2 level as 0

const char *ssid = "......";   // User's wifi id 
const char *password = "......";   // Wifi password
WiFiServer server(80);

void setup() {
  Serial.begin(9600);
  while(!Serial){}
	Serial.println("Gas sensor is working.");

  if(!display.begin(SSD1306_SWITCHCAPVCC, 0x3C)) {
    Serial.println(F("SSD1306 Allocation (FAILED)"));
    for(;;);
  }
  // Render a initial text on OLED
	display.clearDisplay(); // Clear display buffer.
	display.setTextSize(2);
	display.setTextColor(WHITE); // Draw white text.
	display.setCursor(0, 0); // Start at top left corner.
	display.cp437(true); // Enable Code Page 437 font, included ASCII and UTF-8.
	display.display();
	delay(1000);
  TextScroll();
  Processing();

  WiFi.mode(WIFI_AP);
	
	WiFi.begin(ssid, password); // Connect to WLAN.
	while(WiFi.status() != WL_CONNECTED){
		delay(1000);
	}	
	Serial.println("Successfully connected to WLAN.");
	
	Serial.print("URL: ");
	Serial.print("http://");
	Serial.print(WiFi.localIP());
	Serial.println("/");	
	
	server.begin();
	Serial.println("Server started. (Port 80)");
}

void loop() 
{
  int c = analogRead(0);
  display.clearDisplay();
  display.setCursor(0, 0);  

  p = c - n;   // Formula for caculating PPM

  display.setTextSize(1.8);  // text size
  display.setTextColor(WHITE);   //text color
  display.setCursor(0,0);   // cursor location
  display.println("Quality of Air");   // print out the title
  display.setTextSize(2);
  display.print(p);
  display.print("  PPM");
  delay(50);
  display.display(); 

  // Check if the server has established.
	WiFiClient client = server.available();
	if(!client) return;

	// Wait for the data sent by client.
	while(!client.available())	delay(1);
	
	String request = client.readStringUntil('\r');   // Print the first line.
	
	Serial.println(request);
	client.flush();

  // Response from NodeMCU
	client.println("HTTP/1.1 200 OK");
	client.println("Content-Type: text/HTML");
	client.println("");
	
	// Code for HTML 
	client.println("<!DOCTYPE HTML>");
	client.println("<html>");
	client.println("<head>");
	client.println("<meta charset='utf-8'/>");
	client.println("<title>ESP8266</title>");
  client.println("<meta http-equiv=\"refresh\"content=\"3\">");
	client.println("</head>");
	client.println("<body>");
	client.println("<h3>Air Quality Monitoring System</h3>");
  client.println("--------------------------------------");
  client.println("<br/><br/>");
	client.println("PPM value: ");
  client.println(p); 
	client.println("<br/><br/>");
 	client.println("CO2 value: ");
  client.println(c); 
  client.println("<br/><br/>");
  client.println("--------------------------------------");
	client.println("</body>");
	client.println("</html>");
 }

 void TextScroll(void) {
  display.clearDisplay();
  display.display();   // Update screen 
  display.setTextSize(1.5);   // Draw 2X-scale text
  display.setTextColor(SSD1306_WHITE);
  display.setCursor(0,0);  
  display.println(F("Air Quality"));
  display.println(F("Monitoring System"));
  display.display();    // Show initial text
  display.clearDisplay();
  delay(3000);
}

 void Processing(void) {
 display.clearDisplay();
 display.setTextColor(SSD1306_WHITE);
 display.setTextSize(2);   // Draw 2X-scale text
 display.setCursor(0,0);
 display.println(F("CO2 METER"));
 display.display();   // Show initial text    
 display.clearDisplay();
 delay(3000);
 display.display();

 for(int i = 0; i <= 100; i++)
  {
   display.clearDisplay();
   display.setTextColor(SSD1306_WHITE);
   display.setCursor(0,0);
   display.setTextSize(1.5);
   display.println(F("Preparing..."));
   display.setTextSize(1.5);
   display.setCursor(15,15);
   if (i<100) display.print("");
   if (i<10) display.print("");
   display.print(i);
   display.print("%");   
   display.display(); 
   delay(100);
  }

 }



