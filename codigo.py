while True:
    try:
        num = int(input())
        if num > 0:
            break
        else:
            print("VALOR INVÁLIDO")
    except ValueError:
        print("VALOR INVÁLIDO")

for i in range(1, num + 1):
    if num % i == 0:
        print(i)