#include <iostream>
#include <cmath>

class Geometric {
	double a0, q;
	public:
		Geometric(double a0, double q): a0(a0), q(q){}
		double operator[](int n) const {
			return (n == 0) ? a0 : operator[](n-1)*q;
		}
};

int main() {
const Geometric geometric(1, -0.5);
std::cout << geometric[5] << std::endl; }
