#include <stdio.h>

int main(){

  FILE *fp;
  int i;

  fp = fopen("gen-total.txt", "w+");

  for(i=21; i<=31; i++)
    fprintf(fp, "='%d'!G37\n", i);
  for(i=1; i<=20; i++)
    fprintf(fp, "='%d'!G37\n", i);

  printf("sucess!");

  fclose(fp);

  return 0;
}
