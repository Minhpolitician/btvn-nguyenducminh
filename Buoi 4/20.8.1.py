while(True):

    letters = input(" Type here: ")

    letters = letters.lower()

  
    letter_counts = {}

    for letter in letters:

        letter_counts[letter] = letter_counts.get(letter, 0) + 1


    letter_list = list(letter_counts.items())

    letter_list.sort()

    for letter in range(len(letter_list)):

        if letter_list[letter][0].isalnum():

            print(letter_list[letter][0], letter_list[letter][1])

