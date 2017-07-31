shop = ['T-Shirt', 'Sweater', 'Jeans']

crud = input("Welcome to our shop, what do you want (C, R, U, D)?")
while True:
        if (crud.upper() == 'C'):

                    new_item = str(input('Enter new item: '))

                    shop.append(new_item)

                    print('Our items: ', shop)
                    crud = input("Welcome to our shop, what do you want (C, R, U, D)?")
                    
        elif (crud.upper() == 'R'):

                    print('Our items: ', shop)
                    crud = input("Welcome to our shop, what do you want (C, R, U, D)?")

        elif (crud.upper() == 'U'):

                    update = int(input('Position? '))

                    new_item = str(input('New item?'))

                    shop[update - 1] = new_item

                    print("Our items: ", shop)
                    crud = input("Welcome to our shop, what do you want (C, R, U, D)?")

        elif (crud.upper() == 'D'):

                    delete = int(input('Delete position? '))

                    del shop[delete - 1]

                    print("Our items: ", shop)
                    crud = input("Welcome to our shop, what do you want (C, R, U, D)?")

        else:

                    crud = input("Try again")
 
