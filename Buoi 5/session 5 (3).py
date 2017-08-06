even = []
def extract_even(l):

     for i in range(len(l)):
         if l[i] % 2 == 0:
             even.append(l[i])
     print(even)

     

extract_even([1,4,5,-1,10])
