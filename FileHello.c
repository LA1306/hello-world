#include <stdio.h>

int main(){

  FILE *fp;
  fp = fopen("file01.txt", "w+");
  fprintf(fp, "Hello, i was here!\n");
  fputs("hello hello...\n", fp);
  fclose(fp);

}
