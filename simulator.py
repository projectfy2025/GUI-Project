import serial
import time
import random

port = "COM20"  # one side of the pair
ser = serial.Serial(port, 115200)

while True:
    value = random.randint(1000, 2000)
    ser.write(f"{value}\n".encode())
    time.sleep(0.1)
