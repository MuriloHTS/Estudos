VALOR_CONTA = 500
SAQUES_RESTANTES = 3


def depositar(valor):
    global VALOR_CONTA
    if valor <= 0:
        print("Valor inválido para depósito.")
        return
    else:
        VALOR_CONTA += valor
        print(
            f"Depósito de R${valor:.2f} realizado com sucesso. Saldo atual: R${VALOR_CONTA:.2f}"
        )


def sacar(valor):
    global VALOR_CONTA, SAQUES_RESTANTES
    if SAQUES_RESTANTES > 0:
        if valor <= VALOR_CONTA:
            VALOR_CONTA -= valor
            SAQUES_RESTANTES -= 1
            print(
                f"Saque de R${valor:.2f} realizado com sucesso. Saldo atual: R${VALOR_CONTA:.2f}"
            )
        else:
            print("Saldo insuficiente para realizar o saque.")
    else:
        print("Número máximo de saques diários atingido.")


def consultar_extrato():
    global VALOR_CONTA, SAQUES_RESTANTES
    print("\nExtrato:")
    print(f"Saldo atual: R${VALOR_CONTA:.2f}")
    print(f"Saques diários restantes: {SAQUES_RESTANTES}")


def main():
    while True:
        print("\nMenu:")
        print("1. Depositar")
        print("2. Sacar")
        print("3. Consultar Extrato")
        print("4. Sair")

        opcao = input("Escolha uma opção: ")

        if opcao == "1":
            valor = float(input("\nDigite o valor a ser depositado: "))
            depositar(valor)
        elif opcao == "2":
            valor = float(input("\nDigite o valor a ser sacado: "))
            sacar(valor)
        elif opcao == "3":
            consultar_extrato()
        elif opcao == "4":
            print("\nSaindo...")
            break
        else:
            print("\nOpção inválida.")


main()
