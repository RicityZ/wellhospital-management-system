# 📊 ER Diagram - Entity Relationship Diagram

แสดงความสัมพันธ์ระหว่างตาราง (Tables) ในฐานข้อมูล Wellmeadows

## ส่วนประกอบหลัก

### 1. ตาราง Staff (เจ้าหน้าที่)
- Staff_ID (Primary Key)
- Staff_Name
- Position (แพทย์/พยาบาล/พยาบาลผู้ช่วย)
- Email, Phone, Address

### 2. ตาราง Patient (ผู้ป่วย)
- Patient_ID (Primary Key)
- Patient_Name
- DOB (Date of Birth)
- Gender, Phone, Address
- Insurance_Number

### 3. ตาราง Medical_Record (เวชระเบียน)
- Record_ID (Primary Key)
- Patient_ID (Foreign Key)
- Staff_ID (Foreign Key)
- Diagnosis (การวินิจฉัย)
- Treatment (การรักษา)
- Date_of_Visit

### 4. ตาราง Medication (ยา)
- Medication_ID (Primary Key)
- Record_ID (Foreign Key)
- Med_Name (ชื่อยา)
- Dosage (ปริมาณ)
- Frequency (ความถี่ในการใช้)

### 5. ตาราง Appointment (นัดหมาย)
- Appointment_ID (Primary Key)
- Patient_ID (Foreign Key)
- Staff_ID (Foreign Key)
- Appointment_Date
- Status (ยืนยัน/ยกเลิก/เสร็จสิ้น)

## ความสัมพันธ์ (Relationships)

- **1:N** Staff → Medical_Record (1 เจ้าหน้าที่ ดูแลเวชระเบียนได้หลายฉบับ)
- **1:N** Patient → Medical_Record (1 ผู้ป่วย มีเวชระเบียนได้หลายฉบับ)
- **1:N** Medical_Record → Medication (1 เวชระเบียน มียาได้หลายตัว)
- **1:N** Patient → Appointment (1 ผู้ป่วย มีนัดหมายได้หลายครั้ง)

---

**หมายเหตุ:** ER Diagram นี้ช่วยให้เข้าใจโครงสร้างฐานข้อมูลและความสัมพันธ์ระหว่างตาราง เมื่อออกแบบฐานข้อมูล
