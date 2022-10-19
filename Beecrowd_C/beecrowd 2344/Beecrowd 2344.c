#include <stdio.h>

int main(){

   int resposta, palpite, contador = 5, acertos = 0;

   scanf("%d", &resposta);

   while (contador--){
        scanf("%d", &palpite);
        if (resposta == palpite) acertos++;
   }

   printf("%d\n", acertos);

    return 0;
}
