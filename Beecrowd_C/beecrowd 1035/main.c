    #include<stdio.h>
    #include<math.h>

    int main()
    {
        float v;
        int l;

        scanf("%f", &v);

        l = v * 100;

        printf("NOTAS:\n");

        printf("%d nota(s) de R$ 100.00\n", l / 10000);
        l %= 10000;

        printf("%d nota(s) de R$ 50.00\n", l / 5000);
        l %= 5000;

        printf("%d nota(s) de R$ 20.00\n", l / 2000);
        l %= 2000;

        printf("%d nota(s) de R$ 10.00\n", l / 1000);
        l %= 1000;

        printf("%d nota(s) de R$ 5.00\n", l / 500);
        l %= 500;

        printf("%d nota(s) de R$ 2.00\n", l / 200);
        l %= 200;

        printf("MOEDAS:\n");

        printf("%d moedas(s) de R$ 1.00\n", l / 100);
        l %= 100;

        printf("%d moedas(s) de R$ 0.50\n", l / 50);
        l %= 50;

        printf("%d moedas(s) de R$ 0.25\n", l / 25);
        l %= 25;

        printf("%d moedas(s) de R$ 0.10\n", l / 10);
        l %= 10;

        printf("%d moedas(s) de R$ 0.05\n", l / 5);
        l %= 5;

        printf("%d moedas(s) de R$ 0.01\n", l);


        return 0;
    }
