package com.example.repositories;

	import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import com.example.entity.Booking_Header;

import jakarta.transaction.Transactional;


	@Repository
	@Transactional
	public interface Booking_HeaderRepository extends JpaRepository<Booking_Header, Integer> {

	}

