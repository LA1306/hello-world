#include <stdio.h>

int main(){

  FILE *fp;
  char buff[20];
  
  fp = fopen("file01.txt", "r");
  fgets(buff, 20, (FILE*)fp);
  printf("%s\n", buff);
  fclose(fp);

}
