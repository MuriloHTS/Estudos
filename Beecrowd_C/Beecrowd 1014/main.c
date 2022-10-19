#include <stdio.h>
#include <stdlib.h>

int main()
{
    int km;
    float lt;

    scanf("%d", &km);
    scanf("%f", &lt);

    printf("%.3f km/l", km / lt);


    return 0;
}
