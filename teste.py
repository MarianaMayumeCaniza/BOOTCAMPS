numero = int(input())
while numero < 0 or numero > 10:
    print("VALOR INVÁLIDO")
    numero = int(input())

for i in range(1, 11):
    print(f"{numero} x {i} = {numero*i}")