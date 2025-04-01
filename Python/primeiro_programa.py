def calcular_imc(peso, altura):
    return peso / (altura**2)


def obter_classificacao(imc):
    if imc < 18.5:
        return "Magreza"
    elif 18.5 <= imc < 24.9:
        return "Normal"
    elif 25 <= imc < 29.9:
        return "Sobrepeso"
    elif 30 <= imc < 34.9:
        return "Obesidade grau I"
    elif 35 <= imc < 39.9:
        return "Obesidade grau II"
    else:
        return "Obesidade grau III"


def validar_entrada(valor, tipo):
    try:
        valor = float(valor)
        if valor <= 0:
            raise ValueError("O valor deve ser positivo.")
        return valor
    except ValueError:
        print(f"Entrada inválida! Por favor, insira um número válido para {tipo}.")
        return None


def main():
    print("Bem vindo ao programa de cálculo de IMC!\n")

    peso = None
    while peso is None:
        peso = validar_entrada(input("Digite seu peso (em kg): "), "peso")

    altura = None
    while altura is None:
        altura = validar_entrada(input("Digite sua altura (em metros): "), "altura")

    imc = calcular_imc(peso, altura)
    classificacao = obter_classificacao(imc)

    print(f"Seu IMC é: {imc:.2f}. Você se encaixa como {classificacao}.")


if __name__ == "__main__":
    main()
