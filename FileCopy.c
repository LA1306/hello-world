#include <stdio.h>

int main() {

  FILE *fp1, *fp2;
  char t;

  fp1 = fopen("file01.txt", "r");
  if (fp1 == NULL) {
    puts("open file01 fail");
    return 0;
  }
  //fputs("meo biet ghi gi nua!\n", fp1);

  fp2 = fopen("file01_copy.txt", "w");
  if (fp2 == NULL) {
    puts("open file01_copy fail");
    return 0;
  }
  //fputs("vl\n", fp2);
  
  t = fgetc(fp1);
  while (t != EOF) {
    fputc(t, fp2);
    t = fgetc(fp1);
  } 
  /*
  do {
    t = fgetc(fp1);
    fputc(t, fp2);
  } while(t != EOF);
  */

  fclose(fp1);
  fclose(fp2);
  puts("end!");

  return 0;
}
