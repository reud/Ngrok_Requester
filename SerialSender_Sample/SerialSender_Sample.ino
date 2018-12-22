#include <Arduino.h>
const int buttonPin=12;

 //シリアルで文字さえ送れば検知されるため送る文章(=WORD)はなんでも良いです

const String words="WORD";

void setup(){
    Serial.begin(9600);
    pinMode(buttonPin,INPUT_PULLUP);
}

void loop(){
    int buttonState=digitalRead(buttonPin);
    if(buttonState==LOW){
        Serial.println(words);
        delay(200);
    }
}
