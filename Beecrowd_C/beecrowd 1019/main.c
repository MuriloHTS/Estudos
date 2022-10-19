#include <stdio.h>
#include <stdlib.h>

int main()
{
    int tempo;

    scanf("%d", &tempo);

    printf("%d:", tempo / 3600);
    tempo %= 3600;

    printf("%d:", tempo / 60);
    tempo %= 60;

    printf("%d", tempo);

    return 0;
}
