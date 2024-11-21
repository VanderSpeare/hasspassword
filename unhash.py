import numpy as np

# Hàm giải mã
def decrypt(ciphertext, a_prime, m, omega):
    # Tính số nghịch đảo của omega mod m
    omega_inv = pow(omega, -1, m)
    
    # Chuyển đổi ciphertext sang dạng số nguyên
    ciphertext = int(ciphertext)

    # Giải mã bằng phương pháp quay ngược
    # Tạo danh sách chứa các bit của bản rõ
    plaintext_bits = []
    current_sum = ciphertext
    
    # Giải mã
    for value in reversed(a_prime):
        if current_sum >= value:
            plaintext_bits.append(1)
            current_sum -= value
        else:
            plaintext_bits.append(0)

    # Danh sách bit được tạo ra từ reverse, đảo ngược lại
    plaintext_bits.reverse()
    
    return ''.join(map(str, plaintext_bits))

# Hàm đọc khóa bí mật từ file
def read_private_key(filename):
    with open(filename, "r", encoding="utf-8") as f:
        lines = f.readlines()
        a_prime = eval(lines[0].split(": ")[1])  # Đọc a'
        m = int(lines[1].split(": ")[1])  # Đọc m
        omega = int(lines[2].split(": ")[1])  # Đọc ω
    return a_prime, m, omega

# Chạy chương trình giải mã
if __name__ == "__main__":
    # Đọc bản mã từ file
    with open("cipher.txt", "r", encoding="utf-8") as f:
        ciphertext = f.read().strip()

    # Đọc khóa bí mật
    a_prime, m, omega = read_private_key("private_key.txt")

    # Giải mã bản mã
    decrypted_plaintext = decrypt(ciphertext, a_prime, m, omega)
    print(f"Bản rõ đã giải mã: {decrypted_plaintext}")