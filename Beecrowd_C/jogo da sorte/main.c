#include <stdio.h>
#include <stdlib.h>
#include <time.h>


int main()
{
    int x, y, result, chute;
    char continuar;
    srand(time(NULL));

    do{

    printf("Qual a soma de %d + %d ?\n", x = rand()%10, y = rand()%10);
    scanf("%d", &chute);

    result = x + y;


    if (chute == result)
    {
        printf("voce acertou\n");
    }else printf("voce errou\n");

    printf("quer jogar novamente? (s/n)\n");
    scanf("%c", &continuar);

    }while (continuar == "s");


    return 0;
}
