#include <fstream>
#include <iostream>
#include <vector>
#include <sstream>
typedef struct {
    std::string lastName;
    std::vector<double> points;
    double sumOfPoints = 0;
} student;

int main(int argc, char* argv[]) {
    std::vector<student> students;
    std::string lineS;
    std::ifstream input(argv[1]);
    std::getline(input, lineS);
    while(std::getline(input,lineS)) {
        std::istringstream str(lineS);
        student tmpStudent;
        str >> tmpStudent.lastName;
        double p;
        while(str >> p) {
            tmpStudent.points.push_back(p);
            tmpStudent.sumOfPoints+=p;
        }
        students.push_back(tmpStudent);
    }
    for(student stu : students)
        std::cout << stu.lastName << " " << stu.sumOfPoints << std::endl;
    std::cout << std::endl;
    for(unsigned i = 0; i < students[0].points.size(); ++i) {
        double sum = 0;
        for(student s : students)
            sum += s.points[i];
        std::cout << i+1 <<" "<< sum/students.size() << std::endl;
    }
}
