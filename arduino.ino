#include <Wire.h>
#include <LiquidCrystal_I2C.h>

#include <plclib.h>

LiquidCrystal_I2C lcd(0x27,20,4);  // set the LCD address to 0x27 for a 16 chars and 2 line display


void setup()
{
  Serial.begin(9600);
  lcd.init();                      // initialize the lcd
  lcd.init();
  // Print a message to the LCD.
  lcd.backlight();
  lcd.setCursor(2,1);
  lcd.print("");
  lcd.setCursor(0,2);
  lcd.print("                ");
  lcd.setCursor(2,3);
  lcd.print("2102110257 Sejin");
}


void loop()
{
  unsigned long Now = millis()/1000;
  int Seconds = Now%60;
  int Minutes = (Now/60)%60;
  int Hours = (Now/3600)%24;
  int Days = (Now/3600*24);
  /*
  Serial.print(Days);Serial.print(" :Day ");
  Serial.print(Hours);Serial.print(" :H ");
  Serial.print(Minutes);Serial.print(" :M ");
  Serial.print(Seconds);Serial.println(" :S ");
  delay(1000);
  */

  Serial.println(Now);

  //lcd.print(Days);
  //lcd.print(Hours);
  //lcd.print(Minutes);

  if (Serial.available() > 0){
  // 수신 버퍼에 메시지가 있으면
  // lcd에 출력
   String todo = Serial.readStringUntil('\n');
   lcd.setCursor(0,0);
   lcd.print(todo);
  }

  // 시간 출력
  if (Hours == 24){
    Hours = 0;
  }
  if (Hours < 10){
    lcd.setCursor(5,2);
    lcd.print(Hours);
  } else if(10<=Hours<24){
    lcd.setCursor(4,2);
    lcd.print(Hours/10);
    lcd.setCursor(5,2);
    lcd.print(Hours%10);
  }
  
  lcd.setCursor(6,2);
  lcd.print("H");

  if (0<= Hours <= 12){
    lcd.setCursor(3,1);
    lcd.print("Good   Morning");
  }
  else if(12 < Hours <= 24){
    lcd.setCursor(3,1);
    lcd.print("Good   Evening");
  }

  // 분 출력
  if (Minutes == 0){
    lcd.setCursor(9,2);
    lcd.print(" ");
  }
  if (Minutes < 10){
    lcd.setCursor(10,2);
    lcd.print(Minutes);
  } else if(Minutes >= 10){
    lcd.setCursor(9,2);
    lcd.print(Minutes/10);
    lcd.setCursor(10,2);
    lcd.print(Minutes%10);
  }
  
  lcd.setCursor(11,2);
  lcd.print("M");

  
  // 초 출력
  if(Seconds==0){
    lcd.setCursor(14,2);
    lcd.print(" ");
  }
  if (Seconds < 10){
    lcd.setCursor(15,2);
    lcd.print(Seconds);
  }else if(Seconds < 60){
    lcd.setCursor(14,2);
    lcd.print(Seconds/10);
    lcd.setCursor(15,2);
    lcd.print(Seconds%10);
  }
  
  lcd.setCursor(16,2);
  lcd.print("S");
 
}
