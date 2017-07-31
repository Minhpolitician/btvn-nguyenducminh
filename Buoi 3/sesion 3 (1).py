from turtle import *

speed(-900)

shape("turtle")

colors = ["red", "blue", "brown", "yellow", "grey"]

for i in range (5):

    
    color(colors[i])

    begin_fill()


    forward (50)

    left(90)

    forward(80)

    left (90)

    forward(50)

    left(90)

    forward(80)

    left(90)

    forward(50)

    end_fill()
