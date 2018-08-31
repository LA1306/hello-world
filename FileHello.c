#include <stdio.h>

int main(){

  FILE *fp;
  long int pos;
  fp = fopen("file01.txt", "w+");
  fprintf(fp, "Hello, i was here!\n");
  pos = ftell(fp);
  printf("%ld\n", pos);
  fputs("hello hello...\n", fp);
  fseek(fp, -4, SEEK_CUR);
  pos = ftell(fp);
  printf("%ld/n", pos);
  fclose(fp);

}
