#O programa solicita ao usuário a quantidade de passos do explorar
#retorna em um laço de repetição cada passo dado 
#mensagem: {Explorador} : {x passo}

# Desafio: A Aventura do Explorador

# Entrada
quantidade_passos = int(input())

#TODO: Adicione uma condição para verificar se a quantidade de passos é positiva.
while quantidade_passos <0:
    quantidade_passos = int(input())
  
#Se a quantidade de passos for zero, imprima "Nenhum passo dado na floresta."

if quantidade_passos==0:
    print("Nenhum passo dado na floresta.")

#Caso contrário, utilize um loop for para imprimir a mensagem do explorador, indicando o número do passo.
for variavel_passos in range(1,quantidade_passos+1):
    if variavel_passos==1:
        print(f'Explorador: {variavel_passos} passo')
    else:
        print(f'Explorador: {variavel_passos} passos')
