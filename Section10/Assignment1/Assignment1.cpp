#include <iostream>
#include <string>
using namespace std;

int main(){
    string user_input{}; 
    string first_half{};
    string last_half{};
    size_t i{0};
    string output{};
    getline(cin, user_input);

    while (i != user_input.length()){
        if (i == 0){
            first_half.push_back(user_input[i]);
            cout << first_half << endl;
        }
        else if (i == 1){
            first_half.push_back(user_input[i]);
            last_half.push_back(user_input[0]);
            output = first_half + last_half;
            cout << output << endl;
        }
        else{
            first_half.push_back(user_input[i]);
            last_half.insert(0, static_cast<char>(user_input[(i-1)]), 2);
            output = first_half + last_half;
            cout << output << endl;
        }
        i++;
        }
            

    return 0;
}