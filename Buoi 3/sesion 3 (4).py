import time
slist=[5,7,300,90,24,50,75]



print("Hello, my name is Hiep and these are my sheep sizes")

print(slist)
time.sleep(2)

print("Now my biggest sheep has size", max(slist), "let's shear it")

slist.remove(max(slist))

print("After shearing, here is my flock")

print(slist)



for i in range (1,5):

    print(i, "month(s) has passed, now here is my flock")

    new_list= [x+50*i for x in slist]

    print(new_list)

    time.sleep(2)
print("My flock has size in total: ",end="")

s = sum(new_list)

print(s)

print("I would get ",end="")

print ("$",s*2,sep="")
