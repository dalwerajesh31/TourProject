package com.example.repositories;

import java.sql.Date;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Modifying;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import com.example.entity.Passanger_Master;

import jakarta.transaction.Transactional;

	@Repository
	@Transactional
	public interface Passanger_Master_Repo extends JpaRepository<Passanger_Master,Integer> {
//	@Modifying
//		@Query("update Passanger_Master p set p.pax_name = :pax_name ,p.pax_birthdate = :pax_birthdate,p.pax_type = :pax_type,p.pax_amount = :pax_amount,p.booking_id= :booking_id where p.pax_id = :pax_id")
//		void update(@Param("pax_name") String pax_name,@Param("pax_birthdate") Date pax_birthdate,@Param("pax_type") String pax_type,@Param("pax_amount") int pax_amount,@Param("booking_id")int booking_id,@Param("pax_id")int id);

}
