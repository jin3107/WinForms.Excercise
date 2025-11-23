use QLSHOW
select * from sankhau
select * from show
select * from casi
select mashow, format(ngaybd, 'dd/MM/yyyy') + '_' + c.nghedanh
from sankhau sk, show s, casi c
where sk.MaDD = s.MaDD and s.Casichinh = c.MaCS

select format(ngaybd, 'dd/MM/yyyy'), macs, nghedanh
from show s, casi c
where s.Casichinh = c.MaCS and madd like '%MLT%'

select TenDiaDiem from sankhau where madd like '%TAM%'

select mashow, casichinh, csdonghanh from show
select MaCS, nghedanh from CASI
select mashow, nghedanh from show sh, casi c where sh.CSdonghanh = c.MaCS and CSdonghanh is not null

select 
    sh.Mashow, 
    casichinh.Nghedanh as Casichinh,
    casidonghanh.Nghedanh as CSdonghanh,
    format(sh.Ngaybd, 'dd/MM/yyyy') as Ngaybd, 
    convert(varchar(8), sh.Giobd, 108) as Giobd
from show sh, casi casichinh, casi casidonghanh
where sh.Casichinh = casichinh.MaCS 
    and sh.CSdonghanh = casidonghanh.MaCS
    and sh.Casichinh IN (select Casichinh from show where Mashow like '%MLT03%')
    and sh.Ngaybd IN (select Ngaybd from show where Mashow like '%MLT03%')

SELECT SK.TenDiaDiem, SK.Diachi, S.Ngaybd, C.Nghedanh, 
		CASE WHEN DAY(S.Ngaybd) = 24 AND MONTH(S.Ngaybd) = 12 THEN 700 ELSE 500 END as Giave 
FROM SANKHAU SK, SHOW S, CASI C
WHERE SK.MaDD = S.MaDD AND S.Casichinh = C.MaCS
ORDER BY SK.TenDiaDiem, S.Ngaybd