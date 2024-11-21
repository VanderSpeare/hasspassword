import random
import numpy as np

# Hàm tạo vector siêu tăng
def generate_superincreasing_sequence(n):
    a_prime = []
    total = 0
    for _ in range(n):
        next_val = total + random.randint(1, 10)
        a_prime.append(next_val)
        total += next_val
    return a_prime

# Hàm sinh giá trị m lớn hơn tổng của tất cả các phần tử trong vector siêu tăng a'
def generate_m(a_prime):
    return sum(a_prime) + random.randint(1, 10)

# Hàm sinh giá trị ω (omega) thỏa gcd(ω, m) = 1
def generate_omega(m):
    while True:
        omega = random.randint(2, m - 1)
        if np.gcd(omega, m) == 1:
            return omega

# Hàm sinh khóa
def generate_keys(n):
    a_prime = generate_superincreasing_sequence(n)
    m = generate_m(a_prime)
    omega = generate_omega(m)
    
    # Tính khóa công khai a = omega * a_prime % m
    a = [(omega * ai) % m for ai in a_prime]
    
    # Ghi khóa bí mật và khóa công khai vào file
    with open("private_key.txt", "w", encoding="utf-8") as f:
        f.write(f"a': {a_prime}\n")
        f.write(f"m: {m}\n")
        f.write(f"ω: {omega}\n")  # Ký tự ω sẽ được ghi vào file với mã hóa UTF-8
    
    with open("public_key.txt", "w", encoding="utf-8") as f:
        f.write(f"a: {a}\n")

    return a_prime, m, omega, a

# Hàm mã hóa bản rõ (plaintext) bằng vector công khai a
def encrypt(plaintext, public_key):
    # Chuyển đổi bản rõ thành danh sách các bit
    plaintext_bits = [int(bit) for bit in plaintext.strip()]
    if len(plaintext_bits) > len(public_key):
        raise ValueError("Độ dài bản rõ lớn hơn độ dài vector công khai.")
    
    # Mã hóa bản rõ
    ciphertext = sum([bit * ai for bit, ai in zip(plaintext_bits, public_key)])
    
    # Ghi kết quả mã hóa ra file
    with open("cipher.txt", "w", encoding="utf-8") as f:
        f.write(str(ciphertext))
    
    return ciphertext

# Đọc file bản rõ, tạo file nếu cần và đảm bảo độ dài khớp với N
def read_plaintext_file(filename, n):
    try:
        with open(filename, "r", encoding="utf-8") as f:
            plaintext = f.read().strip()
            # Đảm bảo độ dài chuỗi bit không lớn hơn N
            if len(plaintext) > n:
                print(f"Chuỗi bit trong '{filename}' dài hơn {n} bit. Sẽ cắt ngắn để khớp độ dài.")
                plaintext = plaintext[:n]
            elif len(plaintext) < n:
                print(f"Chuỗi bit trong '{filename}' ngắn hơn {n} bit. Sẽ thêm '0' để khớp độ dài.")
                plaintext = plaintext.ljust(n, '0')
            return plaintext
    except FileNotFoundError:
        # Tạo file bản rõ mẫu nếu file chưa tồn tại
        sample_text = "1" * n  # Tạo chuỗi bit mẫu có độ dài đúng bằng N
        with open(filename, "w", encoding="utf-8") as f:
            f.write(sample_text)
        print(f"File '{filename}' không tồn tại. Đã tạo file mẫu với nội dung '{sample_text}'.")
        return sample_text

# Chạy chương trình
if __name__ == "__main__":
    # Nhập độ dài của vector khóa bí mật a'
    N = int(input("Nhập độ dài của vector khóa bí mật N: "))
    
    # Sinh khóa bí mật và khóa công khai
    a_prime, m, omega, public_key = generate_keys(N)
    
    # Đọc file bản rõ
    plaintext = read_plaintext_file("plaintext.txt", N)
    
    # Mã hóa và ghi kết quả vào file
    ciphertext = encrypt(plaintext, public_key)
    print("Quá trình mã hóa hoàn tất. Kết quả đã được lưu vào cipher.txt.")
