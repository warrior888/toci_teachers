--
-- PostgreSQL database dump
--

-- Started on 2015-08-01 21:27:49

SET client_encoding = 'UTF8';
SET standard_conforming_strings = off;
SET check_function_bodies = false;
SET client_min_messages = warning;
SET escape_string_warning = off;

--
-- TOC entry 303 (class 2612 OID 16386)
-- Name: plpgsql; Type: PROCEDURAL LANGUAGE; Schema: -; Owner: postgres
--

CREATE PROCEDURAL LANGUAGE plpgsql;


ALTER PROCEDURAL LANGUAGE plpgsql OWNER TO postgres;

SET search_path = public, pg_catalog;

SET default_tablespace = '';

SET default_with_oids = false;

--
-- TOC entry 1476 (class 1259 OID 26229)
-- Dependencies: 3
-- Name: applicationtests; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE applicationtests (
    id integer NOT NULL,
    codesnipet text NOT NULL,
    rightanswers text NOT NULL
);


ALTER TABLE public.applicationtests OWNER TO postgres;

--
-- TOC entry 1475 (class 1259 OID 26227)
-- Dependencies: 3 1476
-- Name: applicationtests_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE applicationtests_id_seq
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;


ALTER TABLE public.applicationtests_id_seq OWNER TO postgres;

--
-- TOC entry 1768 (class 0 OID 0)
-- Dependencies: 1475
-- Name: applicationtests_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE applicationtests_id_seq OWNED BY applicationtests.id;


--
-- TOC entry 1769 (class 0 OID 0)
-- Dependencies: 1475
-- Name: applicationtests_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('applicationtests_id_seq', 4, true);


--
-- TOC entry 1480 (class 1259 OID 26251)
-- Dependencies: 3
-- Name: testsresults; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE testsresults (
    id integer NOT NULL,
    fk_id_applicationtests integer NOT NULL,
    fk_id_users integer NOT NULL,
    result text
);


ALTER TABLE public.testsresults OWNER TO postgres;

--
-- TOC entry 1479 (class 1259 OID 26249)
-- Dependencies: 3 1480
-- Name: testsresults_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE testsresults_id_seq
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;


ALTER TABLE public.testsresults_id_seq OWNER TO postgres;

--
-- TOC entry 1770 (class 0 OID 0)
-- Dependencies: 1479
-- Name: testsresults_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE testsresults_id_seq OWNED BY testsresults.id;


--
-- TOC entry 1771 (class 0 OID 0)
-- Dependencies: 1479
-- Name: testsresults_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('testsresults_id_seq', 10, true);


--
-- TOC entry 1478 (class 1259 OID 26240)
-- Dependencies: 3
-- Name: users; Type: TABLE; Schema: public; Owner: postgres; Tablespace: 
--

CREATE TABLE users (
    id integer NOT NULL,
    name text,
    surname text,
    email text,
    phone text
);


ALTER TABLE public.users OWNER TO postgres;

--
-- TOC entry 1481 (class 1259 OID 26270)
-- Dependencies: 1557 3
-- Name: testsresultsview; Type: VIEW; Schema: public; Owner: postgres
--

CREATE VIEW testsresultsview AS
    SELECT testsresults.id, testsresults.result, users.surname, applicationtests.codesnipet FROM ((testsresults JOIN users ON ((testsresults.fk_id_users = users.id))) JOIN applicationtests ON ((testsresults.fk_id_applicationtests = applicationtests.id)));


ALTER TABLE public.testsresultsview OWNER TO postgres;

--
-- TOC entry 1477 (class 1259 OID 26238)
-- Dependencies: 1478 3
-- Name: users_id_seq; Type: SEQUENCE; Schema: public; Owner: postgres
--

CREATE SEQUENCE users_id_seq
    INCREMENT BY 1
    NO MAXVALUE
    NO MINVALUE
    CACHE 1;


ALTER TABLE public.users_id_seq OWNER TO postgres;

--
-- TOC entry 1772 (class 0 OID 0)
-- Dependencies: 1477
-- Name: users_id_seq; Type: SEQUENCE OWNED BY; Schema: public; Owner: postgres
--

ALTER SEQUENCE users_id_seq OWNED BY users.id;


--
-- TOC entry 1773 (class 0 OID 0)
-- Dependencies: 1477
-- Name: users_id_seq; Type: SEQUENCE SET; Schema: public; Owner: postgres
--

SELECT pg_catalog.setval('users_id_seq', 4, true);


--
-- TOC entry 1749 (class 2604 OID 26232)
-- Dependencies: 1475 1476 1476
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE applicationtests ALTER COLUMN id SET DEFAULT nextval('applicationtests_id_seq'::regclass);


--
-- TOC entry 1751 (class 2604 OID 26254)
-- Dependencies: 1480 1479 1480
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE testsresults ALTER COLUMN id SET DEFAULT nextval('testsresults_id_seq'::regclass);


--
-- TOC entry 1750 (class 2604 OID 26243)
-- Dependencies: 1478 1477 1478
-- Name: id; Type: DEFAULT; Schema: public; Owner: postgres
--

ALTER TABLE users ALTER COLUMN id SET DEFAULT nextval('users_id_seq'::regclass);


--
-- TOC entry 1760 (class 0 OID 26229)
-- Dependencies: 1476
-- Data for Name: applicationtests; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY applicationtests (id, codesnipet, rightanswers) FROM stdin;
1	ala ma kota	kot jest czerwony
2	thomas and friends	kot jest czerwony
3	stacyjkowo	kot jest czerwony
4	czary mary 	kot jest czerwony
\.


--
-- TOC entry 1762 (class 0 OID 26251)
-- Dependencies: 1480
-- Data for Name: testsresults; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY testsresults (id, fk_id_applicationtests, fk_id_users, result) FROM stdin;
4	1	1	{"text": 8}
5	3	3	{"text": 5}
7	4	4	{"text": 4}
8	2	2	{"text": 89}
9	1	1	{"text": 45}
10	2	4	{"text": 12}
\.


--
-- TOC entry 1761 (class 0 OID 26240)
-- Dependencies: 1478
-- Data for Name: users; Type: TABLE DATA; Schema: public; Owner: postgres
--

COPY users (id, name, surname, email, phone) FROM stdin;
1	jan	kowalski	bzae@dfs.pl	4523564363
2	piotr	nowak	bzae@dfs.pl	4523564363
3	janusz	bazodanowski	bzae@dfs.pl	4523564363
4	ryszard	it	bzae@dfs.pl	4523564363
\.


--
-- TOC entry 1753 (class 2606 OID 26237)
-- Dependencies: 1476 1476
-- Name: applicationtests_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY applicationtests
    ADD CONSTRAINT applicationtests_pkey PRIMARY KEY (id);


--
-- TOC entry 1757 (class 2606 OID 26259)
-- Dependencies: 1480 1480
-- Name: testsresults_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY testsresults
    ADD CONSTRAINT testsresults_pkey PRIMARY KEY (id);


--
-- TOC entry 1755 (class 2606 OID 26248)
-- Dependencies: 1478 1478
-- Name: users_pkey; Type: CONSTRAINT; Schema: public; Owner: postgres; Tablespace: 
--

ALTER TABLE ONLY users
    ADD CONSTRAINT users_pkey PRIMARY KEY (id);


--
-- TOC entry 1758 (class 2606 OID 26260)
-- Dependencies: 1480 1476 1752
-- Name: testsresults_fk_id_applicationtests_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY testsresults
    ADD CONSTRAINT testsresults_fk_id_applicationtests_fkey FOREIGN KEY (fk_id_applicationtests) REFERENCES applicationtests(id);


--
-- TOC entry 1759 (class 2606 OID 26265)
-- Dependencies: 1754 1480 1478
-- Name: testsresults_fk_id_users_fkey; Type: FK CONSTRAINT; Schema: public; Owner: postgres
--

ALTER TABLE ONLY testsresults
    ADD CONSTRAINT testsresults_fk_id_users_fkey FOREIGN KEY (fk_id_users) REFERENCES users(id);


--
-- TOC entry 1767 (class 0 OID 0)
-- Dependencies: 3
-- Name: public; Type: ACL; Schema: -; Owner: postgres
--

REVOKE ALL ON SCHEMA public FROM PUBLIC;
REVOKE ALL ON SCHEMA public FROM postgres;
GRANT ALL ON SCHEMA public TO postgres;
GRANT ALL ON SCHEMA public TO PUBLIC;


-- Completed on 2015-08-01 21:27:49

--
-- PostgreSQL database dump complete
--

