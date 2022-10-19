#include <stdio.h>
#include <stdlib.h>

int main()
{
    int tempo, velo;
    float comb;

    scanf("%d", &tempo);
    scanf("%d", &velo);

    comb = (tempo * velo) / 12.0;

    printf("%.3f\n", comb);


    return 0;
}
