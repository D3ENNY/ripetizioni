#include<iostream>

int main(){
    int cnt = 0, i=0;

    while(cnt<50){
        if(i%2==0){
            std::cout << cnt << ") " << i << std::endl;
            cnt++;
        }
        i++;
    }
}