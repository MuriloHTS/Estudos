#include <stdio.h>

int main()
{
    int x;
    int y;

    scanf("%d", &x);
    scanf("%d", &y);

    if (x >= 0 && x <= 432 && y >= 0 && y <= 468) printf("dentro\n");

    else printf("fora\n");


    return 0;
}
