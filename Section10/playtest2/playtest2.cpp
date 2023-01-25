#include <iostream>
#include <string>

int main(){
    std::string user_input{};
    std::string reversed_string{};
    std::getline(std::cin, user_input);
    std::size_t i{0};
    std::size_t const len{user_input.length() - 1};
    std::cout << reversed_string.append(0, static_cast<char>(user_input.at(len))) << '\n';
    // while (i != len){
    //     reversed_string.append(0, user_input.at(len - i));

    //     i++;
    // }

    std::cout << reversed_string << '\n';


    return 0;
}