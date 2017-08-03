
prices= {"banana": 4,
        "apple": 2,
        "orange": 1.5,
        "pear": 3}

items = ["banana", 5, "apple", 6, "orange", 3, "pear", 4]
total=0

for i in range(len(items)):
    item = items[i]
    if i%2 ==0:
        price = prices[item]
        print(item," quantity:",items[i+1], " unit price:",price)
        cost= items[i+1]*price
        total += cost

print(" Total price is: ",total)
 
