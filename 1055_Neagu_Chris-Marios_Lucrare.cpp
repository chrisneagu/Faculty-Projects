#include <iostream>
#include <string>
using namespace std;

class MasinaDeCurse {
	const string serieMasina;
	string numeEchipa;
	char* numeSponsor;
	int nrTururiGrandPrix;
	float lungimeTur;
	int nrTururiEfectuate;
	float* timpPeTurEfectuat;
	static float timpMinimPeTur;

public:
	//1
	MasinaDeCurse() : serieMasina("BMW") {
		numeEchipa = "Necunoscuta";
		numeSponsor = new char[strlen("Anonim") + 1];
		strcpy_s(numeSponsor, strlen("Anonim") + 1, "Anonim");
		nrTururiGrandPrix = 0;
		lungimeTur = 0;
		nrTururiEfectuate = 0;
	}
	//2
	MasinaDeCurse(string numeEchipa, float lungimeTur, float* timpPeTurEfectuat,int nrTururiEfectuate):serieMasina("BMW") {
		if (numeEchipa.empty())
			throw new exception("Nume Echipa empty");
		else
			this->numeEchipa = numeEchipa;
		if(lungimeTur<=0)
			throw new exception("lungime tur<=0");
		else
			this->lungimeTur = lungimeTur;

		if (nrTururiEfectuate <= 0)
			throw new exception("nr tururi<=0");
		else
			this->nrTururiEfectuate = nrTururiEfectuate;

		if (timpPeTurEfectuat == nullptr)
			throw new exception("nr tururi<=0");
		else
			this->timpPeTurEfectuat = new float[nrTururiEfectuate];

		for (int i = 0; i < nrTururiEfectuate; i++)
			this->timpPeTurEfectuat[i] = timpPeTurEfectuat[i];

		numeSponsor = new char[strlen("Anonim") + 1];
		strcpy_s(numeSponsor, strlen("Anonim") + 1, "Anonim");
		nrTururiGrandPrix = 0;
	}
	//3
	~MasinaDeCurse() {
		if (numeSponsor != nullptr)
			delete[] numeSponsor;
		if (timpPeTurEfectuat != nullptr)
			delete[] timpPeTurEfectuat;
		cout << "\nDestructor\n";
	}
	//4
	string getnumeEchipa() {
		return numeEchipa;
	}

	void setnumeEchipa(string numeEchipa) {
		if (numeEchipa.empty())
			throw new exception("Nume Echipa empty");
		else
			this->numeEchipa = numeEchipa;
	}

	float* gettimpPeTurEfectuat() {
		return timpPeTurEfectuat;
	}
	
	void settimpPeTurEfectuat(int nrTururiEfectuate, float* timpPeTurEfectuat) {
		if (nrTururiEfectuate <= 0)
			throw new exception("nr tururi<=0");
		else
			this->nrTururiEfectuate = nrTururiEfectuate;

		if (timpPeTurEfectuat == nullptr)
			throw new exception("nr tururi<=0");
		else
		{
			if (this->timpPeTurEfectuat != nullptr)
				delete[] this->timpPeTurEfectuat;
			this->timpPeTurEfectuat = new float[nrTururiEfectuate];
			for (int i = 0; i < nrTururiEfectuate; i++)
				this->timpPeTurEfectuat[i] = timpPeTurEfectuat[i];
		}
	}
	//5
	MasinaDeCurse(const MasinaDeCurse& masina) {
	
		this->numeEchipa = masina.numeEchipa;
		this->lungimeTur = masina.lungimeTur;
		this->nrTururiGrandPrix = masina.nrTururiGrandPrix;
		this->nrTururiEfectuate = masina.nrTururiEfectuate;
		
		this->timpPeTurEfectuat = new float[nrTururiEfectuate];
		for (int i = 0; i < nrTururiEfectuate; i++)
			this->timpPeTurEfectuat[i] = masina.timpPeTurEfectuat[i];

		numeSponsor = new char[strlen(masina.numeSponsor) + 1];
		strcpy_s(numeSponsor, strlen(masina.numeSponsor) + 1, masina.numeSponsor);
	}
	//6
	MasinaDeCurse& operator=(MasinaDeCurse& masina) {
		if (this != &masina) {
			this->numeEchipa = masina.numeEchipa;
			this->lungimeTur = masina.lungimeTur;
			this->nrTururiGrandPrix = masina.nrTururiGrandPrix;
			this->nrTururiEfectuate = masina.nrTururiEfectuate;

			if (this->timpPeTurEfectuat != nullptr)
				delete[] this->timpPeTurEfectuat;

			if (numeSponsor != nullptr)
				delete[] this->numeSponsor;

			this->timpPeTurEfectuat = new float[nrTururiEfectuate];
			for (int i = 0; i < nrTururiEfectuate; i++)
				this->timpPeTurEfectuat[i] = masina.timpPeTurEfectuat[i];

			numeSponsor = new char[strlen(masina.numeSponsor) + 1];
			strcpy_s(numeSponsor, strlen(masina.numeSponsor) + 1, masina.numeSponsor);
		}
		return *this;
	}

	//7

	friend ostream& operator<<(ostream& out, const MasinaDeCurse& masina);
	friend istream& operator>>(istream& in, MasinaDeCurse& masina);

	//8

	MasinaDeCurse& operator+=(float timp) {
		if (nrTururiEfectuate < nrTururiGrandPrix){
			if (timpPeTurEfectuat == nullptr) {
				float* aux = new float[nrTururiEfectuate + 1];
				int i;
				for (i = 0; i < nrTururiEfectuate; i++)
					aux[i] = timpPeTurEfectuat[i];
				aux[i] = timp;
				delete[] timpPeTurEfectuat;
				timpPeTurEfectuat = aux;
				nrTururiEfectuate++;
			}
			else
			{
				timpPeTurEfectuat = new float[1];
				timpPeTurEfectuat[0] = timp;
				nrTururiEfectuate = 1;
			}
		}
		return *this;
	}

	//9
	bool operator<(const MasinaDeCurse& masina) {
		float sum1 = 0, sum2 = 0;
		for (int i = 0; i < nrTururiEfectuate; i++)
			sum1+=timpPeTurEfectuat[i];
		for (int i = 0; i < masina.nrTururiEfectuate; i++)
			sum2 += masina.timpPeTurEfectuat[i];
		return sum1<sum2;
	}

	//10
	float vitezaMediePeTur(int tur) {
		if (tur > 0 && tur < nrTururiEfectuate)
			return lungimeTur / timpPeTurEfectuat[tur]*3600;
		else
			throw new exception("Index out of range");
	}
};

float MasinaDeCurse::timpMinimPeTur = 2.3;
//tot 7
ostream& operator<<(ostream& out, const MasinaDeCurse& masina) {
	out << masina.serieMasina << ' ' << masina.numeEchipa << ' ' << masina.numeSponsor << ' ' << masina.nrTururiGrandPrix << ' ' << masina.lungimeTur;
	out << ' ' << masina.nrTururiEfectuate<<"\n\n";
	for (int i = 0; i < masina.nrTururiEfectuate; i++)
		out<<masina.timpPeTurEfectuat[i]<<' ';
	out << "\n\n";
	return out;
}

istream& operator>>(istream& in, MasinaDeCurse& masina){
	in >>  masina.numeEchipa >>  masina.numeSponsor >> masina.nrTururiGrandPrix >>  masina.lungimeTur;
	in >>  masina.nrTururiEfectuate;
	for (int i = 0; i < masina.nrTururiEfectuate; i++)
		in >> masina.timpPeTurEfectuat[i];
	return in;
}
int main() {
	MasinaDeCurse a; //1
	cout << a;
	float v[] = { 3.6, 2.4, 6.7 };
	MasinaDeCurse b("Red Bull", 3, v, 3); //2
	cout << b;

	//4
	a.setnumeEchipa("Dark");
	a.settimpPeTurEfectuat(3, v);
	cout << a;

	float* vec = new float[3];
	vec = a.gettimpPeTurEfectuat();
	cout << a.getnumeEchipa() << " ";
	for (int i = 0; i < 3; i++)
		cout << vec[i] << " ";
	cout << endl;
	//5
	MasinaDeCurse c(b);
	cout << c;
	//6
	c = a;
	cout << c;
	//8
	c += 3.14;
	cout << c;


	//9
	bool cond = a < b;
	cout << cond<<endl;

	cout << a.vitezaMediePeTur(2);
	
}