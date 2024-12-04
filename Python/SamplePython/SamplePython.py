# for n in range(1,11):
#     print(n,"",end="")

# a=5
# b=3
# b,a = a,b
# print(a)

# a = [1,2]
# b = [3,4]
# s = 0;
# for n,m in enumerate(a+b):
#     s=s+n*m
# print(s)

# cities = ['Tokyo','Paris','London','Beijing','New York']

# for index,city in enumerate(cities):
#     print(index,city)

# i=0

# while  i < len(cities):
#     print(i,cities[i])
#     i+=1

# i=0
# for n in cities:
#     print(i,n)
#     i+=1


# for n in cities:
#     print(n)

# numbers = [1,2,3,4,5,6,7,8,9,10]
# for number in numbers:
#     if number%2==0:
#         print(number)

# print('数値を入力')
# num = input()
# if int(num) >= 100:
#     print('合格')
# else:
#     print('不合格')

# member = {'name':'坂本龍馬','age':28,'gender':'male'}
# print(member['name'])

# def func():
#     a=1
#     b=2
#     c=a+b
#     print(c)
# func()

from dataclasses import dataclass


@dataclass #クラスの定義
class Item:
    kind: str
    price : int
    
def tax_included_price(item):
    if item.kind == "food":
        return item.price * 1.08
    else:
        return item.price * 1.1
    
def total_amount(items):
    amounts = [tax_included_price(item) for item in items]
    return sum(amounts)

items = [Item("food",200),
         Item("book",1000),
         Item("food",100),]
print(items[0])