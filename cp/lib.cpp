#include "lib.h"

extern "C" int add (int x, int y)
{
    return x + y;
}

extern "C" void GetNumbers(int** array, int* size)
{
    int itrsize = 10;

    int* res = new int[itrsize];
    for ( int i = 0 ; i < itrsize ; i++ )
        res[i] = i;

    *array = res;
    *size = itrsize;
}

extern "C" void FreeNumbers(int* array)
{
    delete[] array;
}
