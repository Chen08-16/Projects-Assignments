#include <GL/glut.h>
#include <stdio.h>
#include <stdlib.h>
#include <math.h>
#include <string.h>
#include <stdarg.h>

#define WINDOW_WIDTH  1100
#define WINDOW_HEIGHT 600
#define D2R 0.0174532

Object sprite01 = Object();

typedef struct
{
	float x, y;
}point_t;

typedef struct
{
	point_t a, b, c, d;
	int angle;
}rect_t;

// Global variables for the template file 
bool up = false, down = false, right = false, left = false;
int  winWidth, winHeight; // width and height for current Window

rect_t rectangle = { 0 };

// Draw a circle for speedometer
// Center at (x,y), Radius, r
void circle(int x, int y, int r)
{
#define PI 3.1415
	float angle;
	glColor3f(0.2, 0.2, 0.2);
	glBegin(GL_POLYGON);
	for (int i = 0; i < 100; i++)
	{
		angle = 2 * PI*i / 100;
		glVertex2f(x + r*cos(angle), y + r*sin(angle));
	}
	glEnd();
}

void print(int x, int y, char *string, void *font)
{
	int len, i;

	glRasterPos2f(x, y);
	len = (int)strlen(string);
	for (i = 0; i<len; i++)
	{
		glutBitmapCharacter(font, string[i]);
	}
}

// Display the text with variables.
void vprint(int x, int y, void *font, char *string, ...)
{
	va_list ap;
	va_start(ap, string);
	char str[1024];
	vsprintf(str, string, ap);
	va_end(ap);

	int len, i;
	glRasterPos2f(x, y);
	len = (int)strlen(str);
	for (i = 0; i<len; i++)
	{
		glutBitmapCharacter(font, str[i]);
	}
}

void vprint2(int x, int y, float size, char *string, ...) {
	va_list ap;
	va_start(ap, string);
	char str[1024];
	vsprintf(str, string, ap);
	va_end(ap);
	glPushMatrix();
	glTranslatef(x, y, 0);
	glScalef(size, size, 1);

	int len, i;
	len = (int)strlen(str);
	for (i = 0; i<len; i++)
	{
		glutStrokeCharacter(GLUT_STROKE_ROMAN, str[i]);
	}
	glPopMatrix();
}

void myCircle_wire(float x, float y, float r) {
	glColor3f(1, 1, 1);
	glLineWidth(1);
	glBegin(GL_LINE_LOOP);
	for (float angle = 0; angle < 360; angle += 5) {
		glVertex2f(r * cos(angle*D2R) + x, r * sin(angle*D2R) + y);
	}
	glEnd();
}

// Draw the line of the speedometer
void draw_lines(float x, float y, float r) {
    glColor3f(1, 1, 1);
    glLineWidth(1);
    glBegin(GL_LINES);
    for (float angle = 0 - 70; angle <= 320 - 70; angle += 20) {
        glVertex2f(r * cos(angle*D2R) + x, r * sin(angle*D2R) + y);
        glVertex2f((r - 25) * cos(angle*D2R) + x, (r - 20) * sin(angle*D2R) + y);
    }
    glEnd();
}

// Draw out the number on the speedometer
void draw_nums(float x, float y, float r) {
	glLineWidth(10);
	glColor3f(1, 1, 1);
	for (float angle = 0 - 70; angle <= 320 - 70; angle += 20) {
		vprint(r * cos(angle*D2R) + x + 10, r * sin(angle*D2R) + y + 10, GLUT_BITMAP_HELVETICA_18, "%d", -1 * ((int)angle - 250));
	}
}

// Function to draw indicator
void calculate_indicator(float x, float y, float r) {
    rectangle.a.x = r * cos((250 + -rectangle.angle) * D2R) + x;
    rectangle.a.y = r * sin((250 + -rectangle.angle) * D2R) + y;

    rectangle.b.x = 15 * cos((150 + -rectangle.angle) * D2R) + x;
    rectangle.b.y = 15 * sin((150 + -rectangle.angle) * D2R) + y;

    rectangle.c.x = 20 * cos((70 + -rectangle.angle) * D2R) + x;
    rectangle.c.y = 20 * sin((70 + -rectangle.angle) * D2R) + y;

    rectangle.d.x = 15 * cos((-10 + -rectangle.angle) * D2R) + x;
    rectangle.d.y = 15 * sin((-10 + -rectangle.angle) * D2R) + y;
}

void draw_indicator(float x, float y, float r) {
	glColor3f(1, 0, 0);
	glBegin(GL_QUADS);
	glVertex2f(rectangle.a.x, rectangle.a.y);
	glVertex2f(rectangle.b.x, rectangle.b.y);
	glVertex2f(rectangle.c.x, rectangle.c.y);
	glVertex2f(rectangle.d.x, rectangle.d.y);
	glEnd();

	glLineWidth(3);
	glColor3f(0.5, 0, 0);
	glBegin(GL_LINE_LOOP);
	glVertex2f(rectangle.a.x, rectangle.a.y);
	glVertex2f(rectangle.b.x, rectangle.b.y);
	glVertex2f(rectangle.c.x, rectangle.c.y);
	glVertex2f(rectangle.d.x, rectangle.d.y);
	glEnd();

	glColor3f(0, 0, 0);
	circle(x, y, 4);
}

//Draw the km/h on the speedometer
void draw_speedInfo(float x, float y) {
	glColor3f(1, 1, 0);
	glLineWidth(3);
	vprint(x + 20, y - 70, GLUT_BITMAP_HELVETICA_18, "km/h");
}

void draw_speedArc(float x, float y, float r){
	glColor3f(0, 1, 0);
	if (rectangle.angle > 260)
		glColor3f(1, 0, 0);
	glLineWidth(4);
	glBegin(GL_LINE_STRIP);
	glVertex2f((r + 16) * cos(250 * D2R) + x, (r + 16) * sin(250 * D2R) + y);
	glVertex2f((r + 4) * cos(250 * D2R) + x, (r + 4) * sin(250 * D2R) + y);
	for (float a = 0; a <= rectangle.angle; a += 5) {
		glVertex2f((r + 4) * cos((250 + -a)*D2R) + x, (r + 4) * sin((250 + -a)*D2R) + y);
	}
	glVertex2f((r + 4) * cos((250 + -rectangle.angle) * D2R) + x, (r + 4) * sin((250 + -rectangle.angle) * D2R) + y);
	glVertex2f((r + 16) * cos((250 + -rectangle.angle) * D2R) + x, (r + 16) * sin((250 + -rectangle.angle) * D2R) + y);
	glEnd();
	glBegin(GL_LINE_STRIP);
	for (float a = 0; a <= rectangle.angle; a++) {
		glVertex2f((r + 16) * cos((250 + -a)*D2R) + x, (r + 16) * sin((250 + -a)*D2R) + y);
	}
	glEnd();
}

// Display out the drawing
void display_outline() {
	myCircle_wire(-300, 50, 172);
}

void display_speedText() {
	draw_lines(-300, 50, 170);
	draw_nums(-325, 35, 120);
}

void display_indicator() {
	calculate_indicator(-300, 50, 160);
	draw_indicator(-300, 50, 248/2);
	draw_speedInfo(-340, -25);
}

// Draw a circle for the oil pressure gauge
// The following function are nearly same with the speedometer one
void circle2(int x, int y, int r)
{
#define PI 3.1415
	float angle;
	glBegin(GL_POLYGON);
	for (int i = 0; i < 100; i++)
	{
		angle = 2 * PI*i / 100;
		glVertex2f(x + r*cos(angle), y + r*sin(angle));
	}
	glEnd();
}

void print2(int x, int y, char *string, void *font)
{
	int len, i;

	glRasterPos2f(x, y);
	len = (int)strlen(string);
	for (i = 0; i<len; i++)
	{
		glutBitmapCharacter(font, string[i]);
	}
}

// display text with variables.
void vprint3(int x, int y, void *font, char *string, ...)
{
	va_list ap;
	va_start(ap, string);
	char str[1024];
	vsprintf(str, string, ap);
	va_end(ap);

	int len, i;
	glRasterPos2f(x, y);
	len = (int)strlen(str);
	for (i = 0; i<len; i++)
	{
		glutBitmapCharacter(font, str[i]);
	}
}

void vprint4(int x, int y, float size, char *string, ...) {
	va_list ap;
	va_start(ap, string);
	char str[1024];
	vsprintf(str, string, ap);
	va_end(ap);
	glPushMatrix();
	glTranslatef(x, y, 0);
	glScalef(size, size, 1);

	int len, i;
	len = (int)strlen(str);
	for (i = 0; i<len; i++)
	{
		glutStrokeCharacter(GLUT_STROKE_ROMAN, str[i]);
	}
	glPopMatrix();
}

void myCircle_wire2(float x, float y, float r) {
	glColor3f(1, 1, 1);
	glLineWidth(1);
	glBegin(GL_LINE_LOOP);
	for (float angle = 0; angle < 360; angle += 5) {
		glVertex2f(r * cos(angle*D2R) + x, r * sin(angle*D2R) + y);
	}
	glEnd();
}

void draw_lines2(float x, float y, float r) {
    glColor3f(1, 1, 1);
    glLineWidth(1);
    glBegin(GL_LINES);
    for (float angle = 60; angle <= 220 ; angle += 20) {
        glVertex2f(r * cos(angle*D2R) + x, r * sin(angle*D2R) + y);
        glVertex2f((r - 25) * cos(angle*D2R) + x, (r - 20) * sin(angle*D2R) + y);
    }
    glEnd();
}

void draw_nums2(float x, float y, float r) {
    glLineWidth(10);
    glColor3f(1, 1, 1);
    for (float angle = 220; angle >= 60 ; angle -= 20) {
        int num = 8 - (int)((angle - 60) / 20);
        vprint(r * cos(angle*D2R) + x + 5, r * sin(angle*D2R) + y, GLUT_BITMAP_HELVETICA_18, "%d", num);
    }
}

void calculate_indicator2(float x, float y, float r){
	rectangle.angle += 15; 
	rectangle.a.x = r * cos((250 + -rectangle.angle) * D2R) + x;
	rectangle.a.y = r * sin((250 + -rectangle.angle) * D2R) + y;

	rectangle.b.x = 15 * cos((150 + -rectangle.angle) * D2R) + x;
	rectangle.b.y = 15 * sin((150 + -rectangle.angle) * D2R) + y;

	
	rectangle.c.x = 20 * cos((70 + -rectangle.angle) * D2R) + x;
	rectangle.c.y = 20 * sin((70 + -rectangle.angle) * D2R) + y;

	rectangle.d.x = 15 * cos((-10 + -rectangle.angle) * D2R) + x;
	rectangle.d.y = 15 * sin((-10 + -rectangle.angle) * D2R) + y;
}

void draw_indicator2(float x, float y, float r) {
	glColor3f(1, 0, 0);
	glBegin(GL_QUADS);
	glVertex2f(rectangle.a.x, rectangle.a.y);
	glVertex2f(rectangle.b.x, rectangle.b.y);
	glVertex2f(rectangle.c.x, rectangle.c.y);
	glVertex2f(rectangle.d.x, rectangle.d.y);
	glEnd();

	glLineWidth(3);
	glColor3f(0.5, 0, 0);
	glBegin(GL_LINE_LOOP);
	glVertex2f(rectangle.a.x, rectangle.a.y);
	glVertex2f(rectangle.b.x, rectangle.b.y);
	glVertex2f(rectangle.c.x, rectangle.c.y);
	glVertex2f(rectangle.d.x, rectangle.d.y);
	glEnd();

	glColor3f(0, 0, 0);
	circle(x, y, 4);
}

void draw_speedInfo2(float x, float y) {
	glColor3f(1, 1, 0);
	glLineWidth(3);
	vprint(x + 10, y - 20, GLUT_BITMAP_HELVETICA_18, "x1000/min");
}

void draw_speedArc2(float x, float y, float r){
	glColor3f(0, 1, 0);
	if (rectangle.angle > 260)
		glColor3f(1, 0, 0);
	glLineWidth(4);
	glBegin(GL_LINE_STRIP);
	glVertex2f((r + 16) * cos(250 * D2R) + x, (r + 16) * sin(250 * D2R) + y);
	glVertex2f((r + 4) * cos(250 * D2R) + x, (r + 4) * sin(250 * D2R) + y);
	for (float a = 0; a <= rectangle.angle; a += 5) {
		glVertex2f((r + 4) * cos((250 + -a)*D2R) + x, (r + 4) * sin((250 + -a)*D2R) + y);
	}
	glVertex2f((r + 4) * cos((250 + -rectangle.angle) * D2R) + x, (r + 4) * sin((250 + -rectangle.angle) * D2R) + y);
	glVertex2f((r + 16) * cos((250 + -rectangle.angle) * D2R) + x, (r + 16) * sin((250 + -rectangle.angle) * D2R) + y);
	glEnd();
	glBegin(GL_LINE_STRIP);
	for (float a = 0; a <= rectangle.angle; a++) {
		glVertex2f((r + 16) * cos((250 + -a)*D2R) + x, (r + 16) * sin((250 + -a)*D2R) + y);
	}
	glEnd();
}
// End of speedometer and oil pressure gauge 
//
// Draw a Temperature indicator
void draw_temp_indicator(float x, float y, float width, float height) {
    // Set the color of the rectangles
    glColor3f(1, 1, 1);

    // Draw 10 rectangles horizontally
    for (int i = 0; i < 10; i++) {
        // Calculate the x and y coordinates of the rectangle's top-left corner
        float rect_x = x + i * (width + 5);
        float rect_y = y;

        // Draw the rectangle using OpenGL commands
        glBegin(GL_QUADS);
        glVertex2f(rect_x, rect_y);
        glVertex2f(rect_x + width, rect_y);
        glVertex2f(rect_x + width, rect_y + height);
        glVertex2f(rect_x, rect_y + height);
        glEnd();
    }
}

// Temp measurement C
void draw_tempInfo(float x, float y) {
	glColor3f(1, 1, 1);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "C");
}

// Temp measurement H
void draw_tempInfo2(float x, float y) {
	glColor3f(1, 0, 0);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "H");
}

// Draw a Fuel Indicator
void draw_fuel_indicator(float x, float y, float width, float height) {
    // Set the color of the rectangles
    glColor3f(1, 1, 1);

    // Draw 10 rectangles horizontally
    for (int i = 0; i < 10; i++) {
        // Calculate the x and y coordinates of the rectangle's top-left corner
        float rect_x = x + i * (width + 5);
        float rect_y = y;

        // Draw the rectangle using OpenGL commands
        glBegin(GL_QUADS);
        glVertex2f(rect_x, rect_y);
        glVertex2f(rect_x + width, rect_y);
        glVertex2f(rect_x + width, rect_y + height);
        glVertex2f(rect_x, rect_y + height);
        glEnd();
    }
}

// Fuel measurement E 
void draw_fuelInfo(float x, float y) {
	glColor3f(1, 0, 0);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "E");
}

// Fuel measurement F
void draw_fuelInfo2(float x, float y) {
	glColor3f(1, 1, 1);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "F");
}

// Function and Drawing for Some Car Dashboard symbol
// Brake Alert Symbol
void draw_BrakeAlert(float x, float y, float radius)
{
    const int numSegments = 32;
    const float angleStep = 2.0f * M_PI / numSegments;
    
    // Draw the circle outline
    glBegin(GL_LINE_LOOP);
    for (int i = 0; i < numSegments; i++) {
        float angle = i * angleStep;
        glVertex2f(x + radius * cos(angle), y + radius * sin(angle));
    }
    glEnd();
}

void draw_BrakeInfo(float x, float y) {
	glColor3f(1, 0, 0);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "!");
}

// Anti-Lock Brake Warning Symbol
void draw_ABSAlert(float x, float y, float radius)
{
    const int numSegments = 32;
    const float angleStep = 2.0f * M_PI / numSegments;
    
    // Draw the circle outline
    glColor3f(1, 0, 0);
    glBegin(GL_LINE_LOOP);
    for (int i = 0; i < numSegments; i++) {
        float angle = i * angleStep;
        glVertex2f(x + radius * cos(angle), y + radius * sin(angle));
    }
    glEnd();
}

void draw_ABSInfo(float x, float y) {
    glColor3f(1, 0, 0);
    glLineWidth(3);
    vprint(x, y - 50, GLUT_BITMAP_HELVETICA_10, "ABS");  
}

// Time 
void draw_Time(float x, float y) {
    glColor3f(1, 1, 1);
    glLineWidth(3);
    vprint(x, y - 50, GLUT_BITMAP_TIMES_ROMAN_24, "14:36PM");  
}

// Left and Right Signal Light
void draw_LSignal1(float x, float y, float size) {
    // Set the color to green
    glColor3f(0, 1, 0);

    // Apply a 90 degree rotation to the triangle
    glPushMatrix();
    glTranslatef(x, y, 0);
    glRotatef(90, 0, 0, 1);
    glTranslatef(-x, -y, 0);

    // Draw the triangle
    glBegin(GL_TRIANGLES);
    glVertex2f(x, y);
    glVertex2f(x + size, y);
    glVertex2f(x + (size / 2), y + size);
    glEnd();

    // Restore the original transformation
    glPopMatrix();
}

void draw_LSignal2(float x, float y, float width, float height) {
    // Set the color to green
    glColor3f(0, 1, 0);

    // Draw the rectangle
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_RSignal1(float x, float y, float size) {
    // Set the color to green
    glColor3f(0, 1, 0);

    // Apply a 90 degree rotation to the triangle
    glPushMatrix();
    glTranslatef(x, y, 0);
    glRotatef(-90, 0, 0, 1);
    glTranslatef(-x, -y, 0);

    // Draw the triangle
    glBegin(GL_TRIANGLES);
    glVertex2f(x, y);
    glVertex2f(x + size, y);
    glVertex2f(x + (size / 2), y + size);
    glEnd();

    // Restore the original transformation
    glPopMatrix();
}

void draw_RSignal2(float x, float y, float width, float height) {
    // Set the color to green
    glColor3f(0, 1, 0);

    // Draw the rectangle
    sprite01.drawRect(120,233,30,15);
    /*glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();*/
}

// Draw a gas fuel symbol
void draw_FuelSymbol1(float x, float y, float width, float height){
	// Set the color to white
    glColor3f(1, 1, 1);

    // Draw the rectangle
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_FuelSymbol2(float x, float y, float width, float height){
	// Set the color to black
    glColor3f(0, 0, 0);

    // Draw the rectangle
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_FuelSymbol3(float x, float y, float size){
	// Set the color to white
    glColor3f(1, 1, 1);

	// Apply a 90 degree rotation to the triangle
    glPushMatrix();
    glTranslatef(x, y, 0);
    glRotatef(-90, 0, 0, 1);
    glTranslatef(-x, -y, 0);

    // Draw the triangle
    glBegin(GL_TRIANGLES);
    glVertex2f(x, y);
    glVertex2f(x + size, y);
    glVertex2f(x + (size / 2), y + size);
    glEnd();

    // Restore the original transformation
    glPopMatrix();
}

// Draw a Safety Belt Alert symbol
void draw_SafetyBelt1(int x, int y, int r) {
    #define PI 3.1415
    float angle;
    glBegin(GL_POLYGON);
    glColor3f(1, 0, 0);
    for (int i = 0; i < 100; i++) {
        angle = 2 * PI * i / 100;
        glVertex2f(x + r * cos(angle), y + r * sin(angle));
    }
    glEnd();
}

void draw_SafetyBelt2(float x, float y, float width, float height){
    glColor3f(1, 0, 0);

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_SafetyBelt3(float x, float y, float width, float height){
    glColor3f(1, 0, 0);

    glPushMatrix();
    glTranslatef(x + width / 2, y + height / 2, 0);
    glRotatef(-55, 0, 0, 1);
    glTranslatef(-width / 2, -height / 2, 0);

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();

    glPopMatrix();
}

// Draw a Engine Warning Symbol
void draw_EngineWarning1(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning2(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning3(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning4(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning5(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning6(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

void draw_EngineWarning7(float x, float y, float width, float height){
    glColor3f(1, 1, 0); // set the color to yellow

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();
}

// Draw a battery symbol
void draw_Battery(float x, float y, float width, float height){
	glColor3f(1, 0, 0); // set the outline color to red

    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE); // set the polygon mode to draw only outlines

    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();

    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL); // set the polygon mode back to fill mode
    
    glColor3f(1, 0, 0); // set the color to red
    glBegin(GL_QUADS);
    glVertex2f(x + width*0.1, y + height*1.1);
    glVertex2f(x + width*0.9, y + height*1.1);
    glVertex2f(x + width*0.9, y + height*1.2);
    glVertex2f(x + width*0.1, y + height*1.2);
    glEnd();
    
    glColor3f(0, 0, 0); // set the color to black
	glBegin(GL_QUADS);
    glVertex2f(x + width*0.4, y + height*1.1);
    glVertex2f(x + width*0.6, y + height*1.1);
    glVertex2f(x + width*0.6, y + height*1.4);
    glVertex2f(x + width*0.4, y + height*1.4);
    glEnd();
}

void draw_BatteryInfo(float x, float y){
	glColor3f(1, 0, 0);
	glLineWidth(3);
	vprint(x, y - 70, GLUT_BITMAP_HELVETICA_18, "+ -");
}

// Draw a panel frame
void draw_PanelFrame(float x, float y, float width, float height){
    // set the outline color to grey
    glColor3f(0.5, 0.5, 0.5);

    // set the polygon mode to draw only outlines
    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

    // draw the rectangle
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + width, y);
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height);
    glEnd();

    // set the polygon mode back to fill mode
    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);
}
 
void draw_PanelInfo(float x, float y){
	glLineWidth(3);
	vprint(x - 10, y - 45, GLUT_BITMAP_HELVETICA_12, "Km______");
	vprint(x - 10, y - 70, GLUT_BITMAP_HELVETICA_12, "123456");
	vprint(x + 130, y - 45, GLUT_BITMAP_HELVETICA_12, "Temp____");
	vprint(x + 130, y - 70, GLUT_BITMAP_HELVETICA_12, "+15°C");
}

// Draw a gear indicator on the panel
void draw_Gear(float x, float y, float size){
    // set the outline color to black
    glColor3f(0, 0, 0);

    // set the polygon mode to draw only outlines
    glPolygonMode(GL_FRONT_AND_BACK, GL_LINE);

    // draw the square
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + size, y);
    glVertex2f(x + size, y + size);
    glVertex2f(x, y + size);
    glEnd();

    // set the fill color to white
    glColor3f(1, 1, 1);

    // set the polygon mode to fill
    glPolygonMode(GL_FRONT_AND_BACK, GL_FILL);

    // draw the square filled with white color
    glBegin(GL_QUADS);
    glVertex2f(x, y);
    glVertex2f(x + size, y);
    glVertex2f(x + size, y + size);
    glVertex2f(x, y + size);
    glEnd();

    // set the text color to black
    glColor3f(0, 0, 0);

    // print the "P" letter at the middle of the square
    vprint(x + size / 2 - 8, y + size / 2 - 8, GLUT_BITMAP_TIMES_ROMAN_24, "P");
}

// Draw a car door, window, and light indicator
void draw_Car(float x, float y, float width, float height) {
    glColor3f(1.0, 1.0, 1.0); 
    glBegin(GL_QUADS); 
    glVertex2f(x, y); 
    glVertex2f(x + width, y); 
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height); 
    glEnd(); 
}

void draw_Window1(float x, float y, float width, float height) {
    glColor3f(0, 0, 0); 
    glBegin(GL_QUADS); 
    glVertex2f(x, y); 
    glVertex2f(x + width, y); 
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height); 
    glEnd(); 
    
    glColor3f(0, 0, 0); 
    glBegin(GL_QUADS); 
    glVertex2f(x, y - 50); 
    glVertex2f(x + width, y - 50); 
    glVertex2f(x + width, y + height - 50);
    glVertex2f(x, y + height - 50); 
    glEnd(); 
}

void draw_Window2(float x, float y, float width, float height) {
    glColor3f(0, 0, 0); 
    glBegin(GL_QUADS); 
    glVertex2f(x, y); 
    glVertex2f(x + width, y); 
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height); 
    glEnd(); 
    
    glColor3f(0, 0, 0); 
    glBegin(GL_QUADS); 
    glVertex2f(x + 60, y); 
    glVertex2f(x + width + 60, y); 
    glVertex2f(x + width + 60, y + height);
    glVertex2f(x + 60, y + height); 
    glEnd(); 
}

void draw_Door(float x, float y, float width, float height){
	glColor3f(1, 1, 1); 
    glBegin(GL_QUADS); 
    glVertex2f(x, y); 
    glVertex2f(x + width, y); 
    glVertex2f(x + width, y + height);
    glVertex2f(x, y + height); 
    glEnd(); 
    
    glColor3f(1, 1, 1); 
    glBegin(GL_QUADS); 
    glVertex2f(x + 95, y); 
    glVertex2f(x + 95 + width, y); 
    glVertex2f(x + 95 + width, y + height);
    glVertex2f(x + 95, y + height); 
    glEnd(); 
}

void draw_Flight(float x, float y, float width, float height) {
	glColor3f(1, 1, 0);
	glBegin(GL_QUADS);
	glVertex2f(x, y);
	glVertex2f(x + width, y);
	glVertex2f(x + width, y + height);
	glVertex2f(x, y + height);
	glEnd();
	
	glColor3f(1, 1, 0); 
	glBegin(GL_QUADS); 
	glVertex2f(x + 55, y); 
	glVertex2f(x + 55 + width, y); 
	glVertex2f(x + 55 + width, y + height);
	glVertex2f(x + 55, y + height); 
	glEnd(); 
	
	// Draw black outline
	glColor3f(0, 0, 0); 
	glLineWidth(3);
	glBegin(GL_LINE_LOOP); 
	glVertex2f(x, y); 
	glVertex2f(x + width, y); 
	glVertex2f(x + width, y + height);
	glVertex2f(x, y + height); 
	glEnd(); 
	
	glBegin(GL_LINE_LOOP); 
	glVertex2f(x + 55, y); 
	glVertex2f(x + 55 + width, y); 
	glVertex2f(x + 55 + width, y + height);
	glVertex2f(x + 55, y + height); 
	glEnd(); 
}

// Draw a Temperature Indicator Symbol
void draw_TempSymbol1(float x, float y, float width, float height){
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x, y);
	glVertex2f(x + width, y);
	glVertex2f(x + width, y + height);
	glVertex2f(x, y + height);
	glEnd();
}

void draw_TempSymbol2(float x, float y, float width, float height){
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x, y);
	glVertex2f(x + width, y);
	glVertex2f(x + width, y + height);
	glVertex2f(x, y + height);
	glEnd();
	
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x, y + 5);
	glVertex2f(x + width, y + 5);
	glVertex2f(x + width, y + 5 + height);
	glVertex2f(x, y + 5 + height);
	glEnd();
	
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x, y + 10);
	glVertex2f(x + width, y + 10);
	glVertex2f(x + width, y + 10 + height);
	glVertex2f(x, y + 10 + height);
	glEnd();
	
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x - 12, y - 10);
	glVertex2f(x - 12 + width, y - 10);
	glVertex2f(x - 12 + width, y - 10 + height);
	glVertex2f(x - 12, y - 10 + height);
	glEnd();
	
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x + 8, y - 10);
	glVertex2f(x + 8 + width, y - 10);
	glVertex2f(x + 8 + width, y - 10 + height);
	glVertex2f(x + 8, y - 10 + height);
	glEnd();
}

void draw_TempSymbol3(float x, float y, float width, float height){
	glColor3f(1, 1, 1);
	glBegin(GL_QUADS);
	glVertex2f(x + 8, y - 10);
	glVertex2f(x + 8 + width, y - 10);
	glVertex2f(x + 8 + width, y - 10 + height);
	glVertex2f(x + 8, y - 10 + height);
	glEnd();
}

// Display the panel
void display_panel(){
	draw_PanelFrame(-110,-100,225,300);
	draw_PanelInfo(-90,-10);
	draw_Gear(-15,-80, 30);
	draw_Car(-30,20,75,110);
	draw_Window1(-13,75,40,15);
	draw_Window2(-25,45,5,30);
	draw_Flight(-30,120,20,10);
	draw_Door(-50,100,20,5);
}

// Display the symbols
void display_symbol() {
	draw_ABSAlert(50,-150,15);
	draw_ABSInfo(40, -104);
	draw_BrakeAlert(90,-150,15);
	draw_BrakeInfo(87, -86);
	draw_Battery(-47,-162,30,20);
	draw_BatteryInfo(-45,-87);
	draw_EngineWarning1(-100,-160,25,15);
	draw_EngineWarning2(-70,-160,5,15);
	draw_EngineWarning3(-107,-158,3,13);
	draw_EngineWarning4(-106,-154,36,5);
	draw_EngineWarning5(-90,-163,15,3);
	draw_EngineWarning6(-100,-140,15,3);
	draw_EngineWarning7(-95,-154,5,15);
	draw_FuelSymbol1(285,-180,20,30);
	draw_FuelSymbol2(289,-165,13,10);
	draw_FuelSymbol3(310,-160,10);
	draw_LSignal1(-140,225,30);
	draw_LSignal2(-140,233,30,15);
	draw_RSignal1(150,255,30);
	draw_RSignal2();
	draw_SafetyBelt1(10,-140,5);
	draw_SafetyBelt2(5,-165,10,20);
	draw_SafetyBelt3(47,-82,5,25);
	draw_TempSymbol1(-300,-170,5,25);
	draw_TempSymbol2(-300,-160,10,2);
	draw_TempSymbol3(-320,-165,30,2);
	draw_Time(-40,280);
}

// Display the speedometer and oil pressure gauge
void display_outline2() {
	myCircle_wire2(300, 50, 172);
}

void display_speedText2() {
	draw_lines2(300, 50, 170);
	draw_nums2(285, 45, 120);
}

void display_indicator2() {
	calculate_indicator2(300, 50, 160);
	draw_indicator2(300, 50, 248/2);
	draw_speedInfo2(280, -25);
	draw_temp_indicator(-425, -210, 20, 20);
	draw_fuel_indicator(175, -210, 20, 20);
	draw_fuelInfo(155, -130);
	draw_fuelInfo2(430, -130);
	draw_tempInfo(-450, -130);
	draw_tempInfo2(-170, -130);
}

void display()
{
	glClearColor(0, 0, 0, 0);
	glClear(GL_COLOR_BUFFER_BIT);

	display_symbol();
	
	display_outline();
	display_speedText();
	display_indicator();
	
	display_outline2();
	display_speedText2();
	display_indicator2();
	display_panel();

	glutSwapBuffers();
}

// This function is called when the window size changes.
// w : is the new width of the window in pixels.
// h : is the new height of the window in pixels.

void onResize(int w, int h)
{
	winWidth = w;
	winHeight = h;
	glViewport(0, 0, w, h);
	glMatrixMode(GL_PROJECTION);
	glLoadIdentity();
	glOrtho(-w / 2, w / 2, -h / 2, h / 2, -1, 1);
	glMatrixMode(GL_MODELVIEW);
	glLoadIdentity();
	display(); // refresh window.
}

void Init() {

	// Smoothing shapes
	glEnable(GL_BLEND);
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);

}

int main(int argc, char *argv[])
{

	glutInit(&argc, argv);
	glutInitDisplayMode(GLUT_RGB | GLUT_DOUBLE);
	glutInitWindowSize(WINDOW_WIDTH, WINDOW_HEIGHT); // Set the size of the window
	glutCreateWindow("Car Dashboard"); // Set the title of the window

	glutDisplayFunc(display);
	glutReshapeFunc(onResize);

	Init();

	glutMainLoop();
}
