from turtle import *

shape ("turtle")

speed (-1)



colors = ["red", "blue", "purple", "yellow", "grey"]

 

from turtle import *

speed(-1)

for n in range (3,8):

    color(colors[n-3])

    for a in range (n):

        forward (100)

        left (360/n)
