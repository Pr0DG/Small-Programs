#include <iostream>
#include <string>
#include <vector>

std::vector<std::string> splitString(const std::string&, char);

int main() {
	std::string str = "Ala ma kota.";
	std::vector<std::string> words = splitString(str, ' ');
	std::cout<<"Words in \""<<str<<"\": "<< words.size() << std::endl;
	for(std::string s : words) std::cout << s << std::endl;}

std::vector<std::string> splitString(const std::string& str, char splitCh) {
	std::vector<char> tmpWord;
	std::vector<std::string> wordsInString;
	for(char c : str) {
		if(c != splitCh) {
			tmpWord.push_back(c);
			continue;}			
		else {
			if(tmpWord.empty()) continue;
			wordsInString.push_back({tmpWord.begin(), tmpWord.end()});
			tmpWord.clear();}}
	if(!tmpWord.empty())
	wordsInString.push_back({tmpWord.begin(), tmpWord.end()});
	return wordsInString; }
