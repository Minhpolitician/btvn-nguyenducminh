from turtle import *



l = int(input("length:"))

x = int (input ("x:"))

y = int (input ("y:"))

def draw_star (l):

    
        penup()
        forward (1)
        forward (x-1)
        left (90)
        forward (y)
        pendown()

        for i in range (5) :

            forward (l)

            left (144)

    



       

draw_star (l)
