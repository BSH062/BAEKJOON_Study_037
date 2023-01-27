#define _CRT_SECURE_NO_WARNINGS
#include<stdio.h>

int main()
{
	int a, b, c;

	scanf("%d %d %d", &a, &b, &c);
	//가변비용보다 판매가격이 작거나 같으면 -1 
	if (b >= c)
	{
		printf("-1");
	}
	else
	{
		printf("%d", a / (c - b) + 1);
	}

}