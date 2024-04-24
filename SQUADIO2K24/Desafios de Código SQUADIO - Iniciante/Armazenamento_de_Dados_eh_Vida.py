#Programa calcula o aumento da produção.
#entrada é o valor atual e o aumento em porcentagem
#saida o aumento total

capacidade_atual, aumento_percentual = map(int, input().split())


# TODO: Calcule a nova capacidade do disco de Mithril
#para calcular a nova capidade é só pegar a capacidade atual e multiplicar por 
#pelo aumento porcentual tela. A entrada está em inteiro, então passa para decimal

nova_capacidade = capacidade_atual * (1+ (aumento_percentual/100))

print(int(nova_capacidade))

print(round(nova_capacidade))