import math

def colisao_elastica(m1, m2, v1i, v2i):
    v1f = ((m1 - m2) * v1i + 2 * m2 * v2i) / (m1 + m2)
    v2f = (2 * m1 * v1i + (m2 - m1) * v2i) / (m1 + m2)
    return v1f, v2f

def main():
    print("Digite as informações da primeira partícula:")
    m1 = float(input("Massa (em kg): "))
    v1i = float(input("Velocidade inicial (em m/s): "))
    
    print("\nDigite as informações da segunda partícula:")
    m2 = float(input("Massa (em kg): "))
    v2i = float(input("Velocidade inicial (em m/s): "))
    
    v1f, v2f = colisao_elastica(m1, m2, v1i, v2i)
    
    print("\nVelocidades finais após a colisão:")
    print("Velocidade final da primeira partícula: {:.2f} m/s".format(v1f))
    print("Velocidade final da segunda partícula: {:.2f} m/s".format(v2f))

if __name__ == "__main__":
    main()
