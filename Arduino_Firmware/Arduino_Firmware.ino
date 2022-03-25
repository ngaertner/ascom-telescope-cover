/*
 Name:		Arduino_Firmware.ino
 Created:	3/9/2022
 Author:	Julien Lecomte
*/

#include <Servo.h>

constexpr auto COMMAND_PING = "COMMAND:PING";
constexpr auto COMMAND_INFO = "COMMAND:INFO";
constexpr auto COMMAND_GETSTATE = "COMMAND:GETSTATE";
constexpr auto COMMAND_OPEN = "COMMAND:OPEN";
constexpr auto COMMAND_CLOSE = "COMMAND:CLOSE";

constexpr auto RESULT_PING = "RESULT:OK";
constexpr auto RESULT_STATE_UNKNOWN = "RESULT:STATE:UNKNOWN";
constexpr auto RESULT_STATE_OPEN = "RESULT:STATE:OPEN";
constexpr auto RESULT_STATE_CLOSED = "RESULT:STATE:CLOSED";

constexpr auto RESULT_INFO = "RESULT:Automated Dust Cover Firmware v1.0";

constexpr auto ERROR_INVALID_COMMAND = "ERROR:INVALID_COMMAND";

enum DustCoverState {
    open,
    closed
} state;

Servo servo;

// The `setup` function runs once when you press reset or power the board.
void setup() {
    state = closed;

    // Initialize serial port I/O.
    Serial.begin(57600);
    while (!Serial) {
        ; // Wait for serial port to connect. Required for native USB!
    }
    Serial.flush();

    // Initialize servo.
    // Important: We assume that the dust cover is in the closed position!
    // If it's not, then the servo will brutally close it when the system is powered up!
    // That may damage the mechanical parts, so be careful...
    servo.write(0);
    servo.attach(9);
}

// The `loop` function runs over and over again until power down or reset.
void loop() {
    if (Serial.available() > 0) {
        String command = Serial.readStringUntil('\n');
        if (command == COMMAND_PING) {
            handlePing();
        }
        else if (command == COMMAND_INFO) {
            sendFirmwareInfo();
        }
        else if (command == COMMAND_GETSTATE) {
            sendCurrentState();
        }
        else if (command == COMMAND_OPEN) {
            openDustCover();
        }
        else if (command == COMMAND_CLOSE) {
            closeDustCover();
        }
        else {
            handleInvalidCommand();
        }
    }
}

void handlePing() {
    Serial.println(RESULT_PING);
}

void sendFirmwareInfo() {
    Serial.println(RESULT_INFO);
}

void sendCurrentState() {
    switch (state) {
    case open:
        Serial.println(RESULT_STATE_OPEN);
        break;
    case closed:
        Serial.println(RESULT_STATE_CLOSED);
        break;
    default:
        Serial.println(RESULT_STATE_UNKNOWN);
        break;
    }
}

void openDustCover() {
    int pos = servo.read();
    // Serial.print("Current position of servo is ");
    // Serial.println(pos);
    if (pos < 180) {
        for (; pos <= 180; pos++) {
            servo.write(pos);
            delay(30);
        }
    }

    state = open;

    // Notify the driver that we're done
    sendCurrentState();
}

void closeDustCover() {
    int pos = servo.read();
    // Serial.print("Current position of servo is ");
    // Serial.println(pos);
    if (pos > 0) {
        for (; pos >= 0; pos--) {
            servo.write(pos);
            delay(30);
        }
    }

    state = closed;

    // Notify the driver that we're done
    sendCurrentState();
}

void handleInvalidCommand() {
    Serial.println(ERROR_INVALID_COMMAND);
}