#include <stdio.h>
#include <stdlib.h>

int main()
{
    int idade;

    scanf("%d", &idade);

    printf("%d ano(s)\n", idade / 365);
    idade %= 365;

    printf("%d mes(es)\n", idade / 30);
    idade %= 30;

    printf("%d dia(s)\n", idade);

    return 0;
}
