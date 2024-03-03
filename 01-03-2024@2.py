import math

def calcularTrajetoria(velocidade, angulo, peso, intervalo_tempo):
    anguloRad = math.radians(angulo)
    v0x = velocidade * math.cos(anguloRad)
    v0y = velocidade * math.sin(anguloRad)
    tempo_voo = (2 * v0y) / (9.81 * peso)
    x, y = [], []
    tempo = 0
    while tempo <= tempo_voo:
        x_tempo = v0x * tempo
        y_tempo = v0y * tempo - 0.5 * 9.81 * peso * tempo**2
        if y_tempo < 0:
            break
        x.append(x_tempo)
        y.append(y_tempo)
        tempo += intervalo_tempo
    return x, y, tempo_voo

def main():
    try:
        velocidade = float(input("Velocidade inicial do projétil (m/s): "))
        angulo = float(input("Ângulo de lançamento (graus): "))
        peso = float(input("Peso do projétil (kg): "))
        intervalo_tempo = float(input("Intervalo de tempo para calcular a trajetória (s): "))

        x_trajetoria, y_trajetoria, tempo_voo = calcularTrajetoria(velocidade, angulo, peso, intervalo_tempo)

        print("\nTrajetória do Projétil:")
        print("Tempo(s) \t Posição X(m) \t Posição Y(m)")
        for i in range(len(x_trajetoria)):
            print(f"{i * intervalo_tempo:.2f} \t\t {x_trajetoria[i]:.2f} \t\t {y_trajetoria[i]:.2f}")

        print(f"\nTempo de voo até atingir o solo: {tempo_voo:.2f} segundos")

        velocidade_impacto = velocidade * math.cos(math.radians(angulo))
        print(f"Velocidade de impacto no solo: {velocidade_impacto:.2f} m/s")

        tempo_desejado = float(input("\nDigite o tempo para verificar a posição do projétil (s): "))
        if tempo_desejado < 0 or tempo_desejado > tempo_voo:
            raise ValueError("O tempo fornecido está fora do intervalo válido.")

        indice_tempo = int(tempo_desejado / intervalo_tempo)
        print(f"\nPosição do Projétil no tempo {tempo_desejado} segundos:")
        print(f"Posição X: {x_trajetoria[indice_tempo]:.2f} m")
        print(f"Posição Y: {y_trajetoria[indice_tempo]:.2f} m")

    except ValueError as e:
        print("Erro:", e)

if __name__ == "__main__":
    main()
