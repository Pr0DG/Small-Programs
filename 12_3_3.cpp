
#include <iostream> 
#include <vector>

std::vector<double> operator+(const std::vector<double>& v1, const std::vector<double>& v2) {
	std::vector<double> v3;
	for(double el:v1)
		v3.push_back(el);
	for(double el:v2)
		v3.push_back(el);
	return v3;
}

std::vector<double>& operator+=(std::vector<double>& v1, const std::vector<double>& v2) {
	for(double el : v2)
		v1.push_back(el);
	return v1;
}

void print(std::vector<double> const &input)
{
	for (unsigned i = 0; i < input.size(); i++) {
		std::cout << input.at(i) << ' ';
	}
	std::cout << std::endl;
}


int main() {
print(std::vector<double> {6.7, -12.3, 5} + std::vector<double> {0.5, -2.7, 19});
std::vector<double> vector {6.7, -12.3, 5};
print((vector += std::vector<double> {0.5, -2.7}) += std::vector<double> {19});
print(vector); 

}
