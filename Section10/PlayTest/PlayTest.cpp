#include <iostream>
#include <string>
using namespace std;

int main(){
    string selection;
    string temp;
    string message_to_encript;
    string message_to_decrypt;
    string encrypted_message;
    string decrypted_message;
    string alphabet{"abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"};
    string key{"zyxwvutsrqponmlkjihgfedcbaZYXWVUTSRQPONMLKJIHGFEDCBA"};
    size_t indexer{0};
    cout << "You want your message to be encrypted or decryption? ";
    getline(cin, selection);
    if (selection == "encrypted" || selection == "Encrypted" || selection == "encrypt" || selection == "encryption" || selection == "Encrypt" || selection == "Encryption"){
        cout << "Ok, what message do you want to encrypt? ";
        getline(cin, message_to_encript);
        cout << "\nEncripting . . ." << endl;
        for(auto c: message_to_encript){
            indexer = alphabet.find(c);
            encrypted_message += key[indexer];
        }
        cout << "Your encrypted message is " << encrypted_message << endl;

    }
    else if (selection == "decryption" || selection == "decrypted" || selection == "Decrypted" || selection == "decrypt" || selection == "Decrypt" || selection == "Decryption"){
        cout << "Ok, what message do you want to decrypt? ";
        getline(cin, message_to_decrypt);
        cout << "Decrypting . . ." << endl;
        for (auto c: message_to_decrypt){
            indexer = key.find(c);
            decrypted_message += alphabet[indexer];
        }
        cout << "Your decrypted message is: " << decrypted_message << endl;
    
    }
    else
        cout << "Input not supported, try again." << endl;
    return 0;
}