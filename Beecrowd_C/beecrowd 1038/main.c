
#include <stdio.h>
#include <stdlib.h>

    int main()
{
    float N1, N2, N3, N4, media, ex;

    scanf("%f %f %f %f", &N1, &N2, &N3, &N4);

    media = ((2*N1) + (3*N2) + (4*N3) + (1*N4)) / 10;

    printf("Media: %.1f\n", media);

    if (media >= 7.0)
    {
        printf("Aluno aprovado.\n");
    }
    else if (media < 5.0)
    {
        printf("Aluno reprovado.\n");
    }
    else
        printf("Aluno em exame.\n");
        scanf("%f", &ex);
        printf("Nota do exame: %.1f\n", ex);

    media = (media + ex)/ 2;

    if (media >= 5.0)
    {
        printf("Aluno aprovado.\n");
    }
    else if (media < 5.0)
    {
        printf("Aluno reprovado.\n");
    }

    printf("Media final: %.1f\n", media);

    return 0;
}
