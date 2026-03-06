# 🔄 System Flowchart - ขั้นตอนการทำงาน

แสดงขั้นตอนการไหลเวียนของข้อมูลและการทำงานของระบบ

## 1. เข้าสู่ระบบ (Login)
```
Start → Input Username/Password → Verify (Database) 
  ├─ Valid → Dashboard
  └─ Invalid → Error Message
```

## 2. ลงทะเบียนผู้ป่วยใหม่ (Patient Registration)
```
Dashboard → Select "New Patient" → Input Patient Info
  → Validate Data → Save to Database
  → Generate Patient_ID → Success Message
```

## 3. ค้นหาผู้ป่วย (Search Patient)
```
Dashboard → Select "Search" → Input Search Criteria
  → Query Database → Display Results
  → Select Patient → View Patient Details
```

## 4. บันทึกเวชระเบียน (Medical Record Entry)
```
Select Patient → Select "Medical Record" → Input:
  - Staff ID (แพทย์ที่ตรวจ)
  - Diagnosis (การวินิจฉัย)
  - Treatment (การรักษา)
  - Add Medications (เพิ่มยา)
  → Save to Database → Success
```

## 5. จัดนัดหมาย (Make Appointment)
```
Select Patient → Select "Appointment" → Input:
  - Staff ID (เลือกแพทย์/พยาบาล)
  - Appointment Date & Time
  → Check Availability → Save → Confirmation
```

## 6. ออกรายงาน (Generate Reports)
```
Dashboard → Select "Reports" 
  → Choose Report Type:
    - Patient List Report
    - Medical Record Report
    - Medication Report
    - Appointment Schedule
  → Generate → Export (PDF/Excel) → Complete
```

## 7. ออกจากระบบ (Logout)
```
Dashboard → Select "Logout" → Confirm
  → Clear Session → Back to Login Screen
```

---

## Data Flow (การไหลเวียนของข้อมูล)

```
Frontend (VB.NET Forms)
    ↓
Business Logic (VB.NET Classes)
    ↓
Database Layer (SQL Server Connection)
    ↓
SQL Server Database
    ↓
(คืนข้อมูล) ↑
    ↑
Business Logic
    ↑
Frontend (Display)
```

## Decision Points (จุดตัดสินใจ)

1. **Login Validation** - ตรวจสอบว่า Username/Password ถูกต้อง
2. **Data Validation** - ตรวจสอบว่าข้อมูลที่กรอกถูกต้องตามเงื่อนไข
3. **Availability Check** - ตรวจสอบความพร้อมของเจ้าหน้าที่/ห้องรักษา ก่อนใช้เวลาที่นัด
4. **Authority Check** - ตรวจสอบว่าผู้ใช้มีสิทธิ์ในการดำเนินการนั้นหรือไม่

---

**หมายเหตุ:** Flowchart นี้ช่วยให้เข้าใจขั้นตอนการทำงานของระบบและข้อมูลไหลเวียนไปมาอย่างไร
